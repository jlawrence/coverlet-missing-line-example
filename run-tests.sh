testFolder="ExampleProject.Tests/TestResults"
rm -rf "${testFolder:?}/"*

dotnet test --collect:"XPlat Code Coverage;Format=opencover" --settings coverlet.runsettings

# Move code coverage files to a standard location
find $testFolder -maxdepth 2 -name "coverage.*.xml" -exec mv {} $testFolder \;

reportgenerator -reports:"${testFolder:?}/coverage.opencover.xml" -targetdir:"${testFolder:?}/CoverageReport" -reporttypes:Html