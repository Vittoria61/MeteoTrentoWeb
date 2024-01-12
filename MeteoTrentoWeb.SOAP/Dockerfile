FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MeteoTrentoWeb.SOAP/MeteoTrentoWeb.SOAP.csproj", "MeteoTrentoWeb.SOAP/"]
RUN dotnet restore "MeteoTrentoWeb.SOAP/MeteoTrentoWeb.SOAP.csproj"
COPY . .
WORKDIR "/src/MeteoTrentoWeb.SOAP"
RUN dotnet build "MeteoTrentoWeb.SOAP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MeteoTrentoWeb.SOAP.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MeteoTrentoWeb.SOAP.dll"]
