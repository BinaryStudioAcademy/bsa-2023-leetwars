FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /SolutionTester
COPY CSharpTestRun.sh .
COPY SolutionTester.csproj .
RUN dotnet restore /SolutionTester/SolutionTester.csproj
CMD ["sh", "./CSharpTestRun.sh"]