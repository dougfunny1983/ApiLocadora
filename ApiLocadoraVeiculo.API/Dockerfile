#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ApiLocadoraVeiculo.API/ApiLocadoraVeiculo.API.csproj", "ApiLocadoraVeiculo.API/"]
COPY ["ApiLocadoraVeiculo.CrossCutting/ApiLocadoraVeiculo.CrossCutting.csproj", "ApiLocadoraVeiculo.CrossCutting/"]
COPY ["ApiLocadoraVeiculo.Domain.Core/ApiLocadoraVeiculo.Domain.Core.csproj", "ApiLocadoraVeiculo.Domain.Core/"]
COPY ["ApiLocadoraVeiculo.Domain/ApiLocadoraVeiculo.Domain.csproj", "ApiLocadoraVeiculo.Domain/"]
COPY ["ApiLocadoraVeiculo.Application/ApiLocadoraVeiculo.Application.csproj", "ApiLocadoraVeiculo.Application/"]
COPY ["ApiLocadoraVeiculo.Domain.Services/ApiLocadoraVeiculo.Domain.Services.csproj", "ApiLocadoraVeiculo.Domain.Services/"]
COPY ["ApiLocadoraVeiculo.Infrastructure/ApiLocadoraVeiculo.Infrastructure.csproj", "ApiLocadoraVeiculo.Infrastructure/"]
RUN dotnet restore "ApiLocadoraVeiculo.API/ApiLocadoraVeiculo.API.csproj"
COPY . .
WORKDIR "/src/ApiLocadoraVeiculo.API"
RUN dotnet build "ApiLocadoraVeiculo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiLocadoraVeiculo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiLocadoraVeiculo.API.dll"]