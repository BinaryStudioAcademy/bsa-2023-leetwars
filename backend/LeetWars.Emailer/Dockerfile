FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.Emailer/Leetwars.Emailer.WebAPI/LeetWars.Emailer.WebAPI.csproj", "LeetWars.Emailer/Leetwars.Emailer.WebAPI/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]

RUN dotnet restore "LeetWars.Emailer/Leetwars.Emailer.WebAPI/LeetWars.Emailer.WebAPI.csproj"
COPY . .
WORKDIR "/src/LeetWars.Emailer/Leetwars.Emailer.WebAPI"
RUN dotnet build "LeetWars.Emailer.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Emailer.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5080
ENTRYPOINT ["dotnet", "LeetWars.Emailer.WebAPI.dll"]