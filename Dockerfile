FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src
COPY *.sln .
#COPY DemoHerokuTest/*.csproj DemoHerokuTest/
#RUN dotnet restore DemoHerokuTest/*.csproj
COPY TechArtProfileProject/*.csproj TechArtProfileProject/
RUN dotnet restore TechArtProfileProject/*.csproj
COPY . .

#Testing
#FROM base AS testing
#WORKDIR /src/DemoHeroku
#RUN dotnet build
#WORKDIR /src/DemoHerokuTest
#RUN dotnet test

#Publishing
FROM base AS publish
WORKDIR /src/TechArtProfileProject
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
EXPOSE 8081
#COPY --from=build /app/Groundforce.Services.API/gforce.db .
COPY --from=publish /src/publish .
#ENTRYPOINT ["ConsoleApp1.exe"]
ENTRYPOINT ["dotnet", "TechArtProfileProject.dll"]
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet DemoHeroku.dll