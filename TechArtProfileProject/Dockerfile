#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["TechArtProfileProject/TechArtProfileProject.csproj", "TechArtProfileProject/"]
COPY ["TechArtProfileProject.Lib.Core/TechArtProfileProject.Lib.Core.csproj", "TechArtProfileProject.Lib.Core/"]
COPY ["TechArtProfileProject.Lib.Infrastructure/TechArtProfileProject.Lib.Infrastructure.csproj", "TechArtProfileProject.Lib.Infrastructure/"]
COPY ["TechArtProfileProject.Lib.Model/TechArtProfileProject.Lib.Model.csproj", "TechArtProfileProject.Lib.Model/"]
RUN dotnet restore "TechArtProfileProject/TechArtProfileProject.csproj"
COPY . .
WORKDIR "/src/TechArtProfileProject"
RUN dotnet build "TechArtProfileProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechArtProfileProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechArtProfileProject.dll"]