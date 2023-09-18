FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /CSharpBuilder
COPY CSharpBuilder.csproj .
COPY CSharpBuild.sh .
CMD ["sh", "CSharpBuild.sh"]