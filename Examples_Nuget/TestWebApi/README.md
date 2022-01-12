## build and run docker container from Dockerfile
### checkout all source files to local
```
git clone https://github.com/TileDB-Inc/TileDB-Cloud-CSharp.git -b bd/ch13414-webapi-example
```
### build container
```
cd TileDB-Cloud-CSharp/Examples_Nuget/TestWebApi
docker build -t testwebapi -f Dockerfile .
```
### run container
```
docker run -it -p 5000:80 testwebapi
```

### test it in browser or postman, get user information
```
http://localhost:5000/api/User
```

## build and run docker container from gitDockerfile
### build container
```
docker build -t testwebapi -f gitDockerfile .
```
### run container
```
docker run -it -p 5000:80 testwebapi
```
### test it in browser or postman, get user information
```
http://localhost:5000/api/User
```