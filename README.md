## 🧪About this integration test project
This is an example of a integration test project, highlighting a clean and simple structure for testing RESTful APIs.
Follows standard NUnit flow starting in the [TestSetup](https://github.com/akletchka/Example.Api.IntegrationTests/blob/master/Example.Api.IntegrationTests/TestSetup.cs) class with each [Test](https://github.com/akletchka/Example.Api.IntegrationTests/blob/master/Example.Api.IntegrationTests/Tests/MenuItems.cs) class inheriting from [TestBase](https://github.com/akletchka/Example.Api.IntegrationTests/blob/master/Example.Api.IntegrationTests/TestBase.cs).  All API calls are made from its respective [Service](https://github.com/akletchka/Example.Api.IntegrationTests/blob/master/Example.Api.IntegrationTests/Services/MenuItemsService.cs) class.  The models are then present to deserialize the response data into objects.  Logging can easily be added for required test output reporting.

API under test: [spoonacular API](https://spoonacular.com/food-api)

## ⚗️Technologies used
-[Microsoft.NET.Test.SDK](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test): Test host
-[NUnit](https://nunit.org/): Test framework
-[RestSharp](https://restsharp.dev/): REST Api client library
-[FluentAssertions](https://fluentassertions.com/): Extension methods for assertions


## 👟Running the tests
To run the integration tests you will need to have the .net6 SDK installed.  You can use either Visual Studio or the command line to run these tests.  Please note a [Spoonacular api key](https://spoonacular.com/food-api/docs#Authentication) must be defined in the test.runsettings file prior to execution.
```powershell
dotnet test "C:\pathToSolution\Example.Api.IntegrationTests\Example.Api.IntegrationTests.sln" --settings "C:\pathToRunsettings\Example.Api.IntegrationTests\test.runsettings"
```
