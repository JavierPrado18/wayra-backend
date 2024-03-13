FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS http://*:80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ApiPlaces/ApiPlaces.csproj", "ApiPlaces/"]
RUN dotnet restore "ApiPlaces/ApiPlaces.csproj"
COPY . .
WORKDIR "/src/ApiPlaces"
RUN dotnet build "ApiPlaces.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiPlaces.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiPlaces.dll"]