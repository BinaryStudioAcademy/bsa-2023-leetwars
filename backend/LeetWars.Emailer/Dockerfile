FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LeetWars.Emailer/LeetWars.Emailer.csproj", "LeetWars.Emailer/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]

RUN dotnet restore "LeetWars.Emailer/LeetWars.Emailer.csproj"
COPY . .
WORKDIR "/src/LeetWars.Emailer"
RUN dotnet build "LeetWars.Emailer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Emailer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5080
ENTRYPOINT ["dotnet", "LeetWars.Emailer.dll"]