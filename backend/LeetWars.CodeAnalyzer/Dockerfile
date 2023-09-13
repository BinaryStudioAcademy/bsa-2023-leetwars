FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.CodeAnalyzer/LeetWars.CodeAnalyzer.csproj", "LeetWars.CodeAnalyzer/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]

RUN dotnet restore "LeetWars.CodeAnalyzer/LeetWars.CodeAnalyzer.csproj"
COPY . .
WORKDIR "/src/LeetWars.CodeAnalyzer"
RUN dotnet build "LeetWars.CodeAnalyzer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.CodeAnalyzer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5100
ENTRYPOINT ["dotnet", "LeetWars.CodeAnalyzer.dll"]