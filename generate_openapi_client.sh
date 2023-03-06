wget https://raw.githubusercontent.com/TileDB-Inc/TileDB-Cloud-API-Spec/master/openapi-v1.yaml
npx @openapitools/openapi-generator-cli generate -c openapi_config.json -i openapi-v1.yaml -g csharp-netcore -o ./TileDB.Cloud.Rest/
rm openapi-v1.yaml
