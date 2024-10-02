FROM mcr.microsoft.com/dotnet/aspnet:8.0.3-jammy-amd64 AS base
ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 8080
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy-amd64 AS build
WORKDIR /src
RUN mkdir api 
COPY ["ODataBookStore/ODataBookStore.csproj", "/src/api"]
RUN dotnet restore "/src/api/ODataBookStore.csproj"
COPY ["ODataBookStore/", "/src/api"]

WORKDIR /src/api
RUN dotnet build "ODataBookStore.csproj" --configuration Release --runtime linux-x64 -o ./build

FROM build as publish
WORKDIR /src/api
RUN dotnet publish "ODataBookStore.csproj" -c Release -o /app/out

RUN apt-get update && apt-get install -y locales \
    && locale-gen en_US.UTF-8 \
    && update-locale LANG=en_US.UTF-8

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV LANG en_US.UTF-8

FROM base AS final
COPY --from=publish /app/out .


ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1
ENTRYPOINT ["dotnet", "ODataBookStore.dll"]