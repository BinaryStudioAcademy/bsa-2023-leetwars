FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.Notifier/LeetWars.Notifier.WebAPI/LeetWars.Notifier.WebAPI.csproj", "LeetWars.Notifier/LeetWars.Notifier.WebAPI/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]

RUN dotnet restore "LeetWars.Notifier/LeetWars.Notifier.WebAPI/LeetWars.Notifier.WebAPI.csproj"
COPY . .
WORKDIR "/src/LeetWars.Notifier/LeetWars.Notifier.WebAPI"
RUN dotnet build "LeetWars.Notifier.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Notifier.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5070
ENTRYPOINT ["dotnet", "LeetWars.Notifier.WebAPI.dll"]