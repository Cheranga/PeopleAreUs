[![Build status](https://dev.azure.com/cchatangala/PeopleAreUs/_apis/build/status/PROD%20-%20CI)](https://dev.azure.com/cchatangala/PeopleAreUs/_build/latest?definitionId=34)
# Notes

## Important

* The solution is built using VS2017.
* The solution is implemented in `.NET Core 2.1`.
* __Please make sure that you make the `PeopleAreUs.Console` project as the `start up` project if you want to run/debug.__

This contains the documentation for the project.

* [Project Structure](https://github.com/Cheranga/PeopleAreUs#project-structure)
* [Core Projects](https://github.com/Cheranga/PeopleAreUs#core-projects)
* [Domain Projects](https://github.com/Cheranga/PeopleAreUs#domain-projects)
* [Infrastructure Projects](https://github.com/Cheranga/PeopleAreUs#infrastructure-projects)
* [Service Projects](https://github.com/Cheranga/PeopleAreUs#service-projects)
* [Test Projects](https://github.com/Cheranga/PeopleAreUs#test-projects)

## Project Structure

The architecture pattern used in here is the `Clean Architecture` model.

![alt text](https://github.com/Cheranga/TempPeopleAreUs/blob/master/Images/Project%20Architecture%20Diagram.png "Project Structure")

## Core Projects

These projects have very minimum or no dependencies with the other modules and, also with other third-party frameworks/libraries.

* PeopleAreUs.Core

[Back to Top](https://github.com/Cheranga/PeopleAreUs#notes)

## Domain Projects

These projects represents the business domain. The `Services` projects also consolidates the business logic, but it has been moved to a separate layer so that it can face requests from the `Application` layer.

* PeopleAreUs.Domain
* PeopleAreUs.DTO

[Back to Top](https://github.com/Cheranga/PeopleAreUs#notes)

## Infrastructure Projects

These contain the implementations of what has been abstracted out to the `Services`.

* PeopleAreUs.Infrastructure

[Back to Top](https://github.com/Cheranga/PeopleAreUs#notes)

## Service Projects

In this case this service project represents the business logic and orchestrations used.

* PeopleAreUs.Services

[Back to Top](https://github.com/Cheranga/PeopleAreUs#notes)

## Test Projects

These contain the unit and integration tests which is used to test the functionality of the application.

* PeopleAreUs.Infrastructure.Tests
* PeopleAreUs.Services.Integration.Tests
* PeopleAreUs.Services.Tests

[Back to Top](https://github.com/Cheranga/PeopleAreUs#notes)