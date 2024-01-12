FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MeteoTrentoWeb/MeteoTrentoWeb.csproj", "MeteoTrentoWeb/"]
RUN dotnet restore "MeteoTrentoWeb/MeteoTrentoWeb.csproj"
COPY . .
WORKDIR "/src/MeteoTrentoWeb"
RUN dotnet build "MeteoTrentoWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MeteoTrentoWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MeteoTrentoWeb.dll"]
