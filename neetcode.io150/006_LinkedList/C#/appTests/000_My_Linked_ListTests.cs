
using LinkedListSpace;
using NUnit.Framework;


namespace appTests;


[TestFixture]
public class MyLinkedListsTest
{

    [TestCase("[]")]
    public void MyLinkedListPrintList_OnlyHeadNodeEmptyConstructor_ShouldPrintHeadNodeValBetweenSquareBrackets(string expected)
    {
        string result = new MyLinkedList().PrintList();

        Assert.AreEqual(result, expected, $"The expected result was {expected} actual result was {result}.");
    }

    [TestCase(1, "[1]")]
    [TestCase(-9, "[-9]")]
    public void MyLinkedListPrintList_OnlyHeadNode_ShouldPrintHeadNodeValBetweenSquareBrackets(int input, string expected)
    {
        string result = new MyLinkedList(input).PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(-2,  "[-2]")]
    [TestCase(1,  "[1]")]
    public void MyLinkedListAdd_NullHeadNode_ShouldPrintHeadNodeValBetweenSquareBrackets(int input, string expected)
    {
        MyLinkedList testLink = new MyLinkedList();
        testLink.Push(input);
        string result = testLink.PrintList(); 

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(-2, "[1,-2]")]
    [TestCase(1, "[1,1]")]
    public void MyLinkedListPush_HeadNodeValOne_ShouldPrintHeadNodeValBetweenSquareBrackets(int input, string expected)
    {
        MyLinkedList testLinkList = new MyLinkedList(1);

        testLinkList.Push(input);

        string result = testLinkList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(new int[]{1,2,-2,3,4}, "[1,1,2,-2,3,4]")]
    [TestCase(new int[]{-1}, "[1,-1]")]
    public void MyLinkedListPush_HeadNodeValOnePushMultipleValues_ShouldPrintValuesBetweenSquareBrackets(int[] input, string expected)
    {
        MyLinkedList testLinkList = new MyLinkedList(1);

        foreach(int number in input)
        {
            testLinkList.Push(number);

        }

        string result = testLinkList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(new int[]{1,2,-2,3,4}, "[1,2,-2,3,4]")]
    [TestCase(new int[]{-1}, "[-1]")]
    public void MyLinkedListPush_PushAnEnumerable_ShouldPrintValuesBetweenSquareBrackets(int[] input, string expected)
    {
        MyLinkedList testLinkList = new MyLinkedList();

        testLinkList.Push(input);

        string result = testLinkList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(new int[]{1,2,-2,3,4}, "[1,2,-2,3,4]")]
    [TestCase(new int[]{-1}, "[-1]")]
    public void MyLinkedListConstructor_InitaiatedWithEnumerable_ShouldPrintValuesBetweenSquareBrackets(int[] input, string expected)
    {
        MyLinkedList testLinkList = new MyLinkedList(input);

        string result = testLinkList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(new int[]{1}, "[1]")]
    [TestCase(new int[]{-1}, "[-1]")]
    public void MyLinkedListConstructor_InitaiatedWithSingleListNode_ShouldPrintValuesBetweenSquareBrackets(int[] input, string expected)
    {
        MyLinkedList testLinkList = new MyLinkedList(input);

        string result = testLinkList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

    [TestCase(new int[]{1,2,3,4,5,6,100}, "[1,2,3,4,5,6,100]")]
    [TestCase(new int[]{-1,-2,5,1,7}, "[-1,-2,5,1,7]")]
    [TestCase(new int[]{-1000}, "[-1000]")]
    public void MyLinkedListConstructor_InitaiatedWithConnectedListNode_ShouldPrintValuesBetweenSquareBrackets(int[] input, string expected)
    {

        // Create Connected Node
        ListNode headNode = new ListNode(input[0]);
        ListNode currentNode = headNode;
        for(int i = 1; i < input.Length; i++)
        {
            currentNode.next = new ListNode(input[i]);
            currentNode = currentNode.next;
        }

        MyLinkedList testLinkList = new MyLinkedList(headNode);

        string result = testLinkList.PrintList();

        Assert.AreEqual(result, expected, $"For Input {input}, the expected result was {expected} actual result was {result}.");
    }

}
