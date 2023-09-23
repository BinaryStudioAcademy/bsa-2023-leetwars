FROM mcr.microsoft.com/dotnet/sdk:6.0-focal
WORKDIR /SolutionTester
COPY SolutionTester.csproj .
RUN dotnet restore /SolutionTester/SolutionTester.csproj
CMD ["sh", "/LocalVolume/CSharpTest.sh"]