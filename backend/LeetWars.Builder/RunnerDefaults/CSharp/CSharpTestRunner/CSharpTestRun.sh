cp /LocalVolume/Solution.cs ./Solution.cs

cp /LocalVolume/Tests.cs ./Tests.cs

cp /LocalVolume/Preloaded.cs ./Preloaded.cs

dotnet test --logger "trx;LogFileName=testresults.trx" --results-directory "/LocalVolume"