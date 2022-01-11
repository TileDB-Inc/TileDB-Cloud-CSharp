# Example Dockerfile for Metadata example

This Dockerfile builds example TileDB.ExampleMetadata inside the Microsoft dotnet images.


## Building

From directory containing TileDB-Cloud-CSharp:

```
docker build -t example_metadata:1.0 - < TileDB-Cloud-CSharp/Examples_Nuget/Docker/Dockerfile.Metadata/Dockerfile 
```

## Usage

```
docker run -ti example_metadata:1.0 /bin/bash
```
