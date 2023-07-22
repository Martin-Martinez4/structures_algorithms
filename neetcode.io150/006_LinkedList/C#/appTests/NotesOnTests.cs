
using LinkedListSpace;
using NUnit.Framework;

/*
    installed 
    NUnit, NUnit3TestAdapter, Microsoft.NET.Test.Sdk in this project
    Added refernece to the project being tested in this project
        In vscode
        relative_path is the relative path to .csproj of project the being tested

        dotnet add reference relative_path
*/
/*
      To test internal stuff
      add the attribute
      [assembly:InternalsVisibleTo(nameOfTestProject)]
      [assembly:InternalsVisibleTo("UtilitiesTests")]

  */

namespace appTests;

/* 
    Naming convention
    methodName_ExpectedBehavior_Scenario
    SumOfEvenNumbers_ShallReturnZero_ForEmptyCollection
    or
    methodName_methodName_ExpectedBehavior_Scenario_ExpectedBehavior
    SumOfEvenNumbers_ForEmptyCollection_ShallReturnZero
*/

[TestFixture]
public class ExampleTests
{
    [Test]
    public void SumOfEvenNumbers_ShallReturnZero_ForEmptyCollection()
    {
        var input = Enumerable.Empty<int>();

        var result = input.SumOfEvenNumbers();

        // Expected Actual
        Assert.AreEqual(0, result);

    }

    // [Test]
    // public void SumOfEvenNumbers_ShallReturnSum_ForNonEmptyCollection()
    // {
    //     var input = new int[] {3,1,4,6,7};

    //     var result = input.SumOfEvenNumbers();

    //     var expected = 10;
    //     var inputAsString = string.Join(", ", input);

    //     // Expected Actual Message
    //     // messages are not always neccessary but they are nice to have
    //     Assert.AreEqual(expected, result, $"For Input {inputAsString}, the expectedresult was {expected} actual result was {result}.");
    // }

    // Test Cases
    // can have multiple parameters
    [TestCase(8)]
    [TestCase(-8)]
    [TestCase(6)]
    [TestCase(0)]
    public void SumOfEvenNumbers_ShallReturnSum_ForNonEmptyCollection(int number)
    {
        var input = new int[] { number };

        var result = input.SumOfEvenNumbers();

        var inputAsString = string.Join(", ", input);

        // Expected Actual Message
        // messages are not always neccessary but they are nice to have
        Assert.AreEqual(number, result, $"For Input {inputAsString}, the expectedresult was {number} actual result was {result}.");
    }

    [TestCase(1, 0)]
    [TestCase(-7, 0)]
    [TestCase(33, 0)]
    public void SumOfEvenNumbers_ShallReturnZero_ForCollectionWIthOnlyOddNumbers(int number, int expected)
    {
        var input = new int[] { number };

        var result = input.SumOfEvenNumbers();

        var inputAsString = string.Join(", ", input);

        // Expected Actual Message
        // messages are not always neccessary but they are nice to have
        Assert.AreEqual(expected, result, $"For Input {inputAsString}, the expectedresult was {number} actual result was {result}.");
    }

    // TestCase like other attributes can only use simple types, nums, Systme.Object, Type, and Single-dimensional arrays as arguments
    // Lists and other stuff cannot be used
    // TestCaseSource is a way to get around this.  
    // Takes a string of a method that will generate the test cases
    // can use the nameof method to get the name from a method that is defined elsewhere or use the name of the function nameof(GetTestCases) vs "GetTestCases"
    [TestCaseSource(nameof(GetSumOfEvenNumbersTestCases))]
    public void SumOfEvenNumbers_ShallReturnSum_ForCollectionThatareLists(IEnumerable<int> input, int expected)
    {
        var result = input.SumOfEvenNumbers();

        var inputAsString = string.Join(", ", input);

        // Expected Actual Message
        // messages are not always neccessary but they are nice to have
        Assert.AreEqual(expected, result, $"For Input {inputAsString}, the expectedresult was {result} actual result was {result}.");
    }

    private static IEnumerable<object> GetSumOfEvenNumbersTestCases()
    {
        return new[]
        {
            new object[] {new int[] {3,1,4,6,9}, 10},
            new object[] {new List<int> {100,200,1}, 300},
            new object[] {new List<int> {-3,-5,1}, 0},
            new object[] {new List<int> {-4,-8,1}, -12},
        };
    }

    [Test]
    public void SumOfEvenNumbers_ShallThrowException_ForNullInput()
    {
        IEnumerable<int>? input = null;

        Assert.Throws<NullReferenceException>(
            () => input!.SumOfEvenNumbers()
        );
    }
}
