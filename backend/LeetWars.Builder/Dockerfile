FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.Builder/LeetWars.Builder.WebAPI/LeetWars.Builder.WebAPI.csproj", "LeetWars.Builder/LeetWars.Builder.WebAPI/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]

RUN dotnet restore "LeetWars.Builder/LeetWars.Builder.WebAPI/LeetWars.Builder.WebAPI.csproj"
COPY . .
WORKDIR "/src/LeetWars.Builder/LeetWars.Builder.WebAPI"
RUN dotnet build "LeetWars.Builder.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Builder.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5100
ENTRYPOINT ["dotnet", "LeetWars.Builder.WebAPI.dll"]