FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.Builder/LeetWars.Builder.csproj", "LeetWars.Builder/"]

RUN dotnet restore "LeetWars.Builder/LeetWars.Builder.csproj"
COPY . .
WORKDIR "/src/LeetWars.Builder"
RUN dotnet build "LeetWars.Builder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Builder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
USER nonroot
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5090
ENTRYPOINT ["dotnet", "LeetWars.Builder.dll"]