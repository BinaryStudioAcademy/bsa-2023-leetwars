FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["LeetWars.Core/LeetWars.Core.WebAPI/LeetWars.Core.WebAPI.csproj", "LeetWars.Core/LeetWars.Core.WebAPI/"]
COPY ["LeetWars.Core/LeetWars.Core.BLL/LeetWars.Core.BLL.csproj", "LeetWars.Core/LeetWars.Core.BLL/"]
COPY ["LeetWars.Core/LeetWars.Core.DAL/LeetWars.Core.DAL.csproj", "LeetWars.Core/LeetWars.Core.DAL/"]
COPY ["LeetWars.Core/LeetWars.Core.Common/LeetWars.Core.Common.csproj", "LeetWars.Core/LeetWars.Core.Common/"]

RUN dotnet restore "LeetWars.Core/LeetWars.Core.WebAPI/LeetWars.Core.WebAPI.csproj"
COPY . .
WORKDIR "/src/LeetWars.Core/LeetWars.Core.WebAPI"
RUN dotnet build "LeetWars.Core.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetWars.Core.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5050
ENTRYPOINT ["dotnet", "LeetWars.Core.WebAPI.dll"]