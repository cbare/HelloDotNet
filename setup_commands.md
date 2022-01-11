# Commands

The commands used to set up this project were:

```sh
dotnet new sln
dotnet new console -o CLI
dotnet new classlib -o Hello
dotnet new mstest -o Tests/Hello.Tests
dotnet sln add CLI/.
dotnet sln add Hello/.
dotnet sln add Tests/Hello.Tests/.
```