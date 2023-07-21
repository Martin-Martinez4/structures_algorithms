// See https://aka.ms/new-console-template for more information
using SlidingWindow;
Console.WriteLine("Hello, World!");

Solutions solutions = new Solutions();

// int test = solutions.MaxProfit(new int[]{7,6,4,3,1});
// int test2 = solutions.MaxProfit(new int[]{7,1,5,3,6,4});
// System.Console.WriteLine(test);
// System.Console.WriteLine(test2); 

int test = solutions.LengthOfLongestSubstring("abcabcbb");
int test2 = solutions.LengthOfLongestSubstring("bbbbb");
System.Console.WriteLine(test);
System.Console.WriteLine(test2); 

