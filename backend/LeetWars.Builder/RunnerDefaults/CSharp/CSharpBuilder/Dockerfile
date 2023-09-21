FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /CSharpBuilder
COPY CSharpBuilder.csproj .
CMD ["sh", "-c", "dotnet build 2>&1 | tee /LocalVolume/buildoutput.txt"]