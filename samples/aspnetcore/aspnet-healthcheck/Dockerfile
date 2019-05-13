FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./aspnetapi/
WORKDIR /app/aspnetapi
RUN dotnet restore

# copy everything else and build app
COPY . ./aspnetapi/
WORKDIR /app/aspnetapi
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/aspnetapi/out ./
ENTRYPOINT ["dotnet", "aspnet-healthcheck.dll"]