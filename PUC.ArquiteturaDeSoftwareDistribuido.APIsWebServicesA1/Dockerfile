#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1/PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.csproj", "PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1/"]
RUN dotnet restore "PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1/PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.csproj"
COPY . .
WORKDIR "/src/PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1"
RUN dotnet build "PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.dll"]