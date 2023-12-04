# Setup

1. Install Git Bash or an equivalent Bash shell
2. Install report generator globally by running this command `dotnet tool install -g dotnet-reportgenerator-globaltool`

# Steps to Reproduce

1. Run the following command: `./run-tests.sh`
2. Open `ExampleProject.Tests/TestResults/CoverageReport`
3. You can see that `MyAsyncClass` does not appear on the test results
4. Edit coverlet.runsettings and remove `CompilerGeneratedAttribute`
5. Run the command again and open the new results file
6. You can now see that `MyAsyncClass` is correctly covered, but `MyRecord` incorrectly shows missing coverage.
