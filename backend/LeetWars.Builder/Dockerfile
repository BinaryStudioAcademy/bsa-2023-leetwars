FROM mcr.microsoft.com/windows/servercore:ltsc2019
RUN net user /add nonroot
USER nonroot

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LeetWars.Builder/LeetWars.Builder.csproj", "LeetWars.Builder/"]
RUN dotnet restore "LeetWars.Builder/LeetWars.Builder.csproj"
COPY ./LeetWars.Builder ./LeetWars.Builder
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