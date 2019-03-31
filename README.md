# DefinityFirstDbUnitTestExercise
This project contains the exercice for Database Unit test for the procedure provided.

The activities carried out are described below:

1. A Fake environment is created to facilitate the use of the tools provided by Visual Studio to configure the unit test.
The created objects are:
 - Table `[AdvisorIndexData]`
 - Procedure `[AdvisorIndexDataGet]`
2. Solution `DbUnitTest` was created, to this solution we added database test project` DbUnitTest`.
3. Using the script `AuxiliarScript.sql` the elements mentioned in step one are built; and once the objects are loaded, a new unit test project is added, which contains the unit test for sql `SqlServerUnitTest1.cs` for the procedure` [AdvisorIndexDataGet] `
4. Two test conditions were added to the unit test:
 - Count of rows: Fake data is created in the table `[AdvisorIndexData]` of which the procedure `[AdvisorIndexDataGet]` obtains data. This test must return 2 records.
 - Expected scheme: The test script returns two tables.
