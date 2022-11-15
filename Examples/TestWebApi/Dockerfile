FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_ENVIRONMENT=Development
#---

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /src
COPY ["TestWebApi.csproj", "."]
RUN dotnet restore "./TestWebApi.csproj"
COPY . .

WORKDIR "/src/."

RUN dotnet build "TestWebApi.csproj" -c Release -o /app/build

#---

FROM build AS publish
RUN dotnet publish "TestWebApi.csproj" -c Release -o /app/publish

#---

FROM base AS final

ENV TILEDB_REST_TOKEN "mytoken"
ENV TILEDB_REST_HOST "https://api.tiledb.com"

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestWebApi.dll"]
