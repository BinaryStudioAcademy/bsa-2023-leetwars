FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.Builder/Leetwars.Builder.WebAPI/LeetWars.Builder.WebAPI.csproj", "LeetWars.Builder/Leetwars.Builder.WebAPI/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]
COPY ["LeetWars.RabbitMQ/LeetWars.RabbitMQ.csproj", "LeetWars.RabbitMQ/"]

RUN dotnet restore "LeetWars.Builder/Leetwars.Builder.WebAPI/LeetWars.Builder.WebAPI.csproj"
COPY . .
WORKDIR "/src/LeetWars.Builder/Leetwars.Builder.WebAPI"
RUN dotnet build "LeetWars.Builder.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Builder.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5090
ENTRYPOINT ["dotnet", "LeetWars.Builder.WebAPI.dll"]