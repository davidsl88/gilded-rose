The following changes have been performed:

* The logic in the Main method (Program class) has been moved to an ItemService to improve testability and separate responsibilities.
* Created different layers to separate concerns.
* Extract duplicated code into private methods.
* Dependency injection has not been used since it would require a workaround to resolve the dependency in the Main static method. Since this is a small project with only one class, I advocated to use the KISS principle. If the project would have been bigger with several interfaces and classes, I would have used dependency injection.
* The Console project has been moved to .NET Core.
* Added unit tests with different test cases.
* Avoid magic numbers and strings by using constants.
