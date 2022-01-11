FROM mcr.microsoft.com/dotnet/sdk:5.0

RUN cd /home && \
  git clone https://github.com/TileDB-Inc/TileDB-Cloud-CSharp.git -b bd/ch13349-metadata-example && \
  dotnet publish TileDB-Cloud-CSharp/Examples_Nuget/TileDB.ExampleMetadata/metadata.csproj -c Release -o /app/example_metadata


RUN cd /app/example_metadata 

WORKDIR /app/example_metadata
RUN dotnet metadata.dll 

 