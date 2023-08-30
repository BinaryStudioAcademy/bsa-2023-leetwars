FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /CSharpRunner
COPY ./CSharpRunner .
COPY ./Program.txt ./Program.cs
CMD ["sh", "./CSharpBuildAndRun.sh"]