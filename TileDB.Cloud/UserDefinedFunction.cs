#nullable enable
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Polly;
using TileDB.Cloud.Rest.Api;
using TileDB.Cloud.Rest.Model;

namespace TileDB.Cloud
{
    public partial class RestUtil
    {
        public static class UserDefinedFunction
        {
            public static readonly UdfApi UdfApi;

            static UserDefinedFunction()
            {
                UdfApi = Client.GetInstance().GetUdfApi();
            }

            #region Execute

            /// <summary>
            /// Execute a generic UDF
            ///
            /// If no `chargedOrg` is provided we will charge the current user's default charged namespace.
            /// This defaults to the current username, but this can be reconfigured on TileDB Cloud Console
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF to execute</param>
            /// <param name="args">JSON formatted arguments to pass to UDF</param>
            /// <param name="chargedOrg">Organization to charge for UDF execution</param>
            /// <returns>Stream containing UDF result</returns>
            public static Stream ExecGeneric(
                string udfUri, string? args = null, string? chargedOrg = null)
            {
                var genericUdf = new GenericUDF(udfInfoName: udfUri.Replace("tiledb://", ""), argument: args);
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.SubmitGenericUDF(chargedOrg ?? GetDefaultChargedNamespace(), genericUdf)
                );
                CheckPolicyResult(policyResult);
                return policyResult.Result;
            }

            /// <summary>
            /// Execute a generic UDF asynchronously
            ///
            /// If no `chargedOrg` is provided we will charge the current user's default charged namespace.
            /// This defaults to the current username, but this can be reconfigured on TileDB Cloud Console
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF to execute</param>
            /// <param name="args">JSON formatted arguments to pass to UDF</param>
            /// <param name="chargedOrg">Organization to charge for UDF execution</param>
            /// <returns>Asynchronous Task containing UDF result Stream</returns>
            public static Task<PolicyResult<Stream>> ExecGenericAsync(
                string udfUri, string? args = null, string? chargedOrg = null)
            {
                var genericUdf = new GenericUDF(udfInfoName: udfUri.Replace("tiledb://", ""), argument: args);
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.SubmitGenericUDFAsync(chargedOrg ?? GetDefaultChargedNamespace(), genericUdf));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            #endregion

            #region Copy / Delete

            /// <summary>
            /// Copy an existing UDF
            /// </summary>
            /// <param name="udfUri">TileDB uri for existing UDF to copy</param>
            /// <param name="uriS3">S3 uri to store copied UDF data</param>
            /// <param name="copyNamespace">Destination namespace for copied UDF. If empty use the namespace of current user</param>
            /// <param name="copyName">Destination name for copied UDF. If empty use the UDF name being copied</param>
            public static void Copy(
                string udfUri, string uriS3, string? copyNamespace = null, string? copyName = null)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);
                var udfCopy = new UDFCopy(uriS3, copyNamespace, copyName);
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.HandleCopyUDF(udfNamespace, udfPath, udfCopy));
                CheckPolicyResult(policyResult);
            }

            /// <summary>
            /// Copy an existing UDF asynchronously
            /// </summary>
            /// <param name="udfUri">TileDB uri for existing UDF to copy</param>
            /// <param name="uriS3">S3 uri to store copied UDF data</param>
            /// <param name="copyNamespace">Destination namespace for copied UDF. If empty use the namespace of current user</param>
            /// <param name="copyName">Destination name for copied UDF. If empty use the UDF name being copied</param>
            /// <returns>Asynchronous Task</returns>
            public static Task CopyAsync(
                string udfUri, string uriS3, string? copyNamespace = null, string? copyName = null)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);
                var udfCopy = new UDFCopy(uriS3, copyNamespace, copyName);
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.HandleCopyUDFAsync(udfNamespace, udfPath, udfCopy));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            /// <summary>
            /// Delete an existing TileDB Cloud UDF
            /// UDF data stored on S3 will also be deleted
            /// </summary>
            /// <param name="udfUri">TileDB uri of existing UDF to delete</param>
            public static void Delete(string udfUri)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.DeleteUDFInfo(udfNamespace, udfPath));
                CheckPolicyResult(policyResult);
            }

            /// <summary>
            /// Delete an existing TileDB Cloud UDF asynchronously
            /// UDF data stored on S3 will also be deleted
            /// </summary>
            /// <param name="udfUri">TileDB uri of existing UDF to delete</param>
            /// <returns>Asynchronous Task</returns>
            public static Task DeleteAsync(string udfUri)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.DeleteUDFInfoAsync(udfNamespace, udfPath));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            #endregion

            #region Share

            /// <summary>
            /// Share a UDF with a namespace
            ///
            /// Permitted actions will not accumulate
            /// By default user is granted UDF fetch access unless `udfActions` are explicitly provided
            /// </summary>
            /// <param name="udfUri">UDF uri to share</param>
            /// <param name="shareNamespace">Namespace to share UDF with</param>
            /// <param name="udfActions">Permitted actions for the shared namespace to take upon the UDF</param>
            public static void Share(string udfUri, string shareNamespace, UDFActions[]? udfActions = null)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);

                var udfSharing = new UDFSharing(new List<UDFActions>(), shareNamespace);
                if (udfActions != null)
                {
                    udfSharing.Actions.AddRange(udfActions);
                }
                else
                {
                    udfSharing.Actions.Add(UDFActions.Fetchudf);
                }
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.ShareUDFInfo(udfNamespace, udfPath, udfSharing));
                CheckPolicyResult(policyResult);
            }

            /// <summary>
            /// Share a UDF with a namespace asynchronously
            ///
            /// Permitted actions will not accumulate
            /// By default user is granted UDF fetch access unless `udfActions` are explicitly provided
            /// </summary>
            /// <param name="udfUri">UDF uri to share</param>
            /// <param name="shareNamespace">Namespace to share UDF with</param>
            /// <param name="udfActions">Permitted actions for the shared namespace to take upon the UDF</param>
            /// <returns>Asynchronous Task</returns>
            public static Task ShareAsync(string udfUri, string shareNamespace, UDFActions[]? udfActions = null)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);

                var udfSharing = new UDFSharing(new List<UDFActions>(), shareNamespace);
                if (udfActions != null)
                {
                    udfSharing.Actions.AddRange(udfActions);
                }
                else
                {
                    udfSharing.Actions.Add(UDFActions.Fetchudf);
                }
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.ShareUDFInfoAsync(udfNamespace, udfPath, udfSharing));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            /// <summary>
            /// Unshare UDF with previously shared namespace
            /// </summary>
            /// <param name="udfUri">UDF uri to unshare</param>
            /// <param name="unshareNamespace">Namespace to unshare</param>
            public static void Unshare(string udfUri, string unshareNamespace)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);
                var udfSharing = new UDFSharing() { Namespace = unshareNamespace };
                // Remove shared actions from a previously shared namespace by providing `null` actions
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.ShareUDFInfo(udfNamespace, udfPath, udfSharing));
                CheckPolicyResult(policyResult);
            }

            /// <summary>
            /// Unshare UDF with previously shared namespace asynchronously
            /// </summary>
            /// <param name="udfUri">UDF uri to unshare</param>
            /// <param name="unshareNamespace">Namespace to unshare</param>
            /// <returns>Asynchronous Task</returns>
            public static Task UnshareAsync(string udfUri, string unshareNamespace)
            {
                var (udfNamespace, udfPath) = SplitUri(udfUri);
                var udfSharing = new UDFSharing() { Namespace = unshareNamespace };
                // Remove shared actions from a previously shared namespace by providing `null` actions
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.ShareUDFInfoAsync(udfNamespace, udfPath, udfSharing));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            #endregion

            #region Info

            /// <summary>
            /// Gets UDF info from TileDB Cloud
            /// </summary>
            /// <param name="udfUri">TileDB uri to retrieve info</param>
            /// <returns>UDFInfo object with properties initialized to match current cloud UDF info</returns>
            public static UDFInfo GetInfo(string udfUri)
            {
                var (nameSpace, udfPath) = SplitUri(udfUri);
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.GetUDFInfo(nameSpace, udfPath));
                CheckPolicyResult(policyResult);
                return policyResult.Result;
            }

            /// <summary>
            /// Gets UDF info from TileDB Cloud asynchronously
            /// </summary>
            /// <param name="udfUri">TileDB uri to retrieve info</param>
            /// <returns>Asynchronous Task containing UDFInfo object</returns>
            public static Task<PolicyResult<UDFInfo>> GetInfoAsync(string udfUri)
            {
                var (nameSpace, udfPath) = SplitUri(udfUri);
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.GetUDFInfoAsync(nameSpace, udfPath));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            /// <summary>
            /// Updates information for TileDB Cloud UDF.
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            /// <param name="udfType">UDFType to assign to cloud UDF</param>
            private static void UpdateUdf(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null,
                UDFType? udfType = null)
            {
                var (nameSpace, arrayPath) = SplitUri(udfUri);
                // If a UDFInfoUpdate property is null, no updates will be applied to that field
                var udfInfoUpdate = new UDFInfoUpdate(name, language, null, imageName, udfType, exec, execRaw, readmeText,
                    licenseId, licenseText, tags?.ToList());
                var policyResult = Client.GetInstance().GetRetryPolicyWrap().ExecuteAndCapture(
                    () => UdfApi.UpdateUDFInfo(nameSpace, arrayPath, udfInfoUpdate));
                CheckPolicyResult(policyResult);
            }

            /// <summary>
            /// Updates information for TileDB Cloud UDF asynchronously
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            /// <param name="udfType">UDFType to assign to cloud UDF</param>
            /// <returns>Asynchronous Task</returns>
            private static Task UpdateUdfAsync(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null,
                UDFType? udfType = null)
            {
                var (nameSpace, arrayPath) = SplitUri(udfUri);
                // If a UDFInfoUpdate property is null, no updates will be applied to that field
                var udfInfoUpdate = new UDFInfoUpdate(name, language, null, imageName, udfType, exec, execRaw, readmeText,
                    licenseId, licenseText, tags?.ToList());
                var policyResult = Client.GetInstance().GetRetryAsyncPolicyWrap().ExecuteAndCaptureAsync(
                    () => UdfApi.UpdateUDFInfoAsync(nameSpace, arrayPath, udfInfoUpdate));
                policyResult.ContinueWith(t => CheckPolicyResult(t.Result));
                return policyResult;
            }

            /// <summary>
            /// Updates information for TileDB Cloud generic UDF.
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            public static void UpdateGenericUdf(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null)
            {
                UpdateUdf(udfUri, readmeText, tags, name, licenseId, licenseText, execRaw, exec, language, imageName,
                    UDFType.Generic);
            }

            /// <summary>
            /// Updates information for TileDB Cloud generic UDF asynchronously
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            /// <returns>Asynchronous Task</returns>
            public static Task UpdateGenericUdfAsync(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null)
            {
                return UpdateUdfAsync(udfUri, readmeText, tags, name, licenseId, licenseText, execRaw, exec, language,
                    imageName, UDFType.Generic);
            }

            /// <summary>
            /// Updates information for TileDB Cloud single-array UDF.
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            public static void UpdateSingleArrayUdf(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null)
            {
                UpdateUdf(udfUri, readmeText, tags, name, licenseId, licenseText, execRaw, exec, language, imageName,
                    UDFType.Singlearray);
            }

            /// <summary>
            /// Updates information for TileDB Cloud single-array UDF asynchronously
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            /// <returns>Asynchronous Task</returns>
            public static Task UpdateSingleArrayUdfAsync(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null)
            {
                return UpdateUdfAsync(udfUri, readmeText, tags, name, licenseId, licenseText, execRaw, exec, language, imageName,
                    UDFType.Singlearray);
            }

            /// <summary>
            /// Updates information for TileDB Cloud multi-array UDF.
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            public static void UpdateMultiArrayUdf(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null)
            {
                UpdateUdf(udfUri, readmeText, tags, name, licenseId, licenseText, execRaw, exec, language, imageName,
                    UDFType.Multiarray);
            }

            /// <summary>
            /// Updates information for TileDB Cloud multi-array UDF.
            ///
            /// Tags will be replaced with tags passed to this function.
            /// To update existing tags call Udf.GetInfo to retrieve and build an updated tag list.
            /// </summary>
            /// <param name="udfUri">TileDB uri for UDF we're updating</param>
            /// <param name="readmeText">UDF README text</param>
            /// <param name="tags">Complete list of tags to associate with UDF</param>
            /// <param name="name">Name of UDF</param>
            /// <param name="licenseId">SPDX license ID to associate license with UDF</param>
            /// <param name="licenseText">License textual information</param>
            /// <param name="execRaw">Raw text used to display UDF function definition in TileDB Cloud UI</param>
            /// <param name="exec">Type-specific executable text to run when UDF is executed</param>
            /// <param name="language">Programming language UDF is written in</param>
            /// <param name="imageName">Optional docker image name to run UDF</param>
            /// <returns>Asynchronous Task</returns>
            public static Task UpdateMultiArrayUdfAsync(
                string udfUri, string? readmeText = null, string[]? tags = null, string? name = null,
                string? licenseId = null, string? licenseText = null, string? execRaw = null,
                string? exec = null, UDFLanguage? language = null, string? imageName = null)
            {
                return UpdateUdfAsync(udfUri, readmeText, tags, name, licenseId, licenseText, execRaw, exec, language,
                    imageName, UDFType.Multiarray);
            }

            #endregion
        }
    }
}