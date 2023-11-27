# Steps to Reproduce

1. Run the following command: `dotnet test --collect:"XPlat Code Coverage;Format=opencover" --settings coverlet.runsettings`
2. Open `ExampleProject.Tests/TestResults/[GUID]/coverage.opencover.xml`
3. On Line 14, you can see `sequenceCoverage="0"`, but it should be `sequenceCoverage="100"`
4. Edit coverlet.runsettings and update change `SkipAutoProps` to `false`
5. Run the command again and open the new results file
6. You can now see that `sequenceCoverage="100"`
