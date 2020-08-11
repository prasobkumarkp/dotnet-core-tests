### Unit tests

## Good init tests

1. First-class citizens (they are important if not more than the production code)
2. Clean, readable and maintainable
3. No Logic (No loops and conditional logics in the test, it's possible for the test to have a bug in future)
4. Isolated (Each test should be written and executed as if its the only test in the world, the test should not call any state and should not assume any state created by any other tests)
5. Not too specific/general (if too general it may not give the confidence that the production code is working)

## What to test

1. Testable code is clean
2. Clean code testable
3. Test the outcome of a function(query functions and command functions)
    1. Query Method: The function row and returns some value (can be a value from DB but, not must). Test the function is returning a value. Test all execution paths.
    1. Command Method: This often involves changing the state of an object memory/writing to DB/calling a web service/sending a message to message queue..., Test the outcomes and well as making the right call.

## What not to test

1. Language features
2. Third-party code

## Naming and Organizing the Tests

1. For each project, there should be a unit test project. ex, MyProject, MyProject.UnitTests (unit test execute faster were as integration tests take longer)
2. Test class for each class in production code. ex, Reservation.cs, ReservationTests.cs
3. Each method in this class should have one or more test methods.
4. Often the number of tests >= Number of execution paths
5. The name of the test should specify the business rule you're testing. Bad test ex, Test1(), SaveCustomerTest(), GetMovies() - Not sure what business rules are tested over here.
6. Naming convention [MethodName]_[Scenario]_[ExpectedBehaviour]
7. If a particular have large and complex methods, so many execution paths and edge cases in that case it may be better to dedicate a separate test class for method. ex, CanBeCancelledBy(), Reservation_CanBeCancelledByTestes.cs
