
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

    [TestCase(new int[]{1,2,-2,3,4}, new int[]{1,2,-2,3,4}, "[-2,-2,1,1,2,2,3,3,4,4]")]
    [TestCase(new int[]{}, new int[]{0}, "[0]")]
    [TestCase(new int[]{}, new int[]{}, "[]")]
    public void MergeTwoSortedLists_TakesTwoHeadsOfSeperateSortedLists_ShouldPrintValsOfTheMergedBetweenSquareBrackets(int[] array1, int[] array2, string expected)
    {       
        Array.Sort(array1);
        Array.Sort(array2);

        MyLinkedList myLinkedList1 = new MyLinkedList(array1);
        MyLinkedList myLinkedList2 = new MyLinkedList(array2);
        Solutions solutions = new Solutions();

        ListNode newHead = solutions.MergeTwoLists(myLinkedList1.getHeadNode(), myLinkedList2.getHeadNode());

        MyLinkedList myMergedList = new MyLinkedList(newHead);

        string result = myMergedList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {array1} {array2}, the expected result was {expected} actual result was {result}.");
    }

}
