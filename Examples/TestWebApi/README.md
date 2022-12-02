# TileDB-Cloud WebAPI Example

This folder contains a test application using .NET WebAPI with TileDB Cloud. The docker-based instructions below will build and run a complete example using the specified token and REST API endpoint.

The application will query TileDB Cloud for the user information associated with the token, and return it in JSON format.

##  Build and run docker container from Dockerfile

1) Checkout all source files to local

```
git clone https://github.com/TileDB-Inc/TileDB-Cloud-CSharp.git -b bd/ch13414-webapi-example
cd TileDB-Cloud-CSharp/Examples_Nuget/TestWebApi
```

2) Optional: change `TILEDB_REST_TOKEN` and `TILEDB_REST_HOST` in Dockerfile and build container, or see below to provide as arguments to `docker run`

3) Build docker image

```
docker build -t testwebapi -f Dockerfile .
```

3) Run container

```
docker run -it -p 5000:80 testwebapi
```

- or if you prefer to providing host and token in command line:

```
docker run --env TILEDB_REST_TOKEN=yourtoken --env TILEDB_REST_HOST=https://api.tiledb.com -it -p 5000:80 testwebapi
```
 
4) Test it in browser or postman, get user information
```
http://localhost:5000/api/User
```

 
