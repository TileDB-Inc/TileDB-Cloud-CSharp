[![Nuget](https://img.shields.io/nuget/v/TileDB.Cloud)](https://www.nuget.org/packages/TileDB.Cloud)

# TileDB-Cloud-CSharp

This repository contains the CSharp client for the TileDB Cloud Service.

## Quick Links

### Installation 
The dependency packages(Newtonsoft.Json, RestSharp, Polly, TileDB.CSharp) will also be added.

```
dotnet add package TileDB.Cloud
```
 
### Quickstart

See [Quickstart](https://github.com/TileDB-Inc/TileDB-Cloud-CSharp/tree/main/Notebooks/quickstart_cloud.ipynb) interactive notebook.

### Regeneration

The TileDB.Cloud.Rest project is generated using [OpenAPI Generator](https://github.com/OpenAPITools/openapi-generator)
To regenerate the TileDB.Cloud.Rest API we need to grab the `openapi-v1.yaml` spec from [TileDB-Inc/TileDB-Cloud-API-Spec](https://github.com/TileDB-Inc/TileDB-Cloud-API-Spec) and pass it to OpenAPI Generator.
This can be done using the `generate_openapi_client.sh` script available in the root of this repository.
This script must be executed from the root of the repository, as it uses relative paths to point to the TileDB.Cloud.Rest project

```bash
git clone git@github.com:TileDB-Inc/TileDB-Cloud-CSharp.git
cd TileDB-Cloud-CSharp
./generate_openapi_client.sh
```
