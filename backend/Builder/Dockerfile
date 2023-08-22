FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Builder/Builder.csproj", "Builder/"]
RUN dotnet restore "Builder/Builder.csproj"
COPY ./Builder ./Builder
WORKDIR "/src/Builder"
RUN dotnet build "Builder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Builder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5090
ENTRYPOINT ["dotnet", "Builder.dll"]