
using LinkedListSpace;
using NUnit.Framework;


namespace appTests;


[TestFixture]
public class SolutionsTests
{

    [TestCase(new int[]{1,2,-2,3,4}, "[4,3,-2,2,1]")]
    [TestCase(new int[]{4,3,-2,2,1}, "[1,2,-2,3,4]")]
    public void ReverseList_TakesAHeadOfAListAsInput_ShouldPrintReversedValsBetweenSquareBrackets(int[] input, string expected)
    {
        MyLinkedList myLinkedList = new MyLinkedList(input);
        Solutions solutions = new Solutions();

        ListNode newHead = solutions.ReverseList(myLinkedList.getHeadNode());

        MyLinkedList myReversedLinkedList = new MyLinkedList(newHead);

        string result = myReversedLinkedList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(new int[]{1,2,-2,3,4}, "[4,3,-2,2,1]")]
    [TestCase(new int[]{4,3,-2,2,1}, "[1,2,-2,3,4]")]
    public void MergeTwoSortedLists_TakesTwoHeadsOfSeperateSortedLists_ShouldPrintValsOfTheMergedBetweenSquareBrackets(int[] input, string expected)
    {
        MyLinkedList myLinkedList = new MyLinkedList(input);
        Solutions solutions = new Solutions();

        ListNode newHead = solutions.ReverseList(myLinkedList.getHeadNode());

        MyLinkedList myReversedLinkedList = new MyLinkedList(newHead);

        string result = myReversedLinkedList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

}
