# TileDB.Cloud - the C# library Wrapper for the TileDB Storage Platform API

TileDB Cloud

## Frameworks supported

- .NET Core 5.0 or later

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.2.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [Polly](https://www.nuget.org/packages/Polly) - 7.2.3 or later
- [TileDB.CSharp](https://www.nuget.org/packages/TileDB.CSharp/) - 5.0.1 or later
- Internal - TileDB.Cloud.Rest - 0.2.2 or later

## Development

In most of the cases debugging should also implicate access to the TileDB Storage Platform API.
Thus, the TileDB.Cloud.Rest library is available as source code in a sibling folder.
On account of the fact that a project cannot be referenced as long as it is not included
in the solution, temporarily, the library included in the TileDB.Cloud.Rest project, should be added
in the solution then added as reference and once develpoment is completed it should be removed.

## Packaging

The first step is to build the project, having as a reference the internal
TileDB.Cloud.Rest project. In order to do so, the following command should be
used to pack the TileDB.Cloud.Rest project:

```bash
nuget pack -Build -OutputDirectory out TileDB.Cloud.Rest.csproj
```

Then, publish TileDB.Cloud.Rest to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual from TileDB.Cloud.

As a last step, the `.nuspec` file should be updated to include the new package
and update version information.
The following command should be used to pack the TileDB.Cloud project

```bash
nuget pack -Build -OutputDirectory out TileDB.Cloud.csproj
```
