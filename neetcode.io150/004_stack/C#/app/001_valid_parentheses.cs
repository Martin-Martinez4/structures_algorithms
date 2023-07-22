
using System.Collections.Generic;

namespace Stack
{
    public partial class Solutions
    {
        /*
            Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            An input string is valid if:

            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order.
            Every close bracket has a corresponding open bracket of the same type.
            

            Example 1:

            Input: s = "()"
            Output: true
            Example 2:

            Input: s = "()[]{}"
            Output: true
            Example 3:

            Input: s = "(]"
            Output: false
            

            Constraints:

            1 <= s.length <= 104
            s consists of parentheses only '()[]{}'.
        */
        // Good Memory Usage bad, Speed.  
        public bool IsValid(string s)
        {
            // One stack to hold opening characters
            // when a closing character is encountered pop a character from the stack
            // If the character does not correspond to the encountered character return false

            Stack<char> openingsStack = new Stack<char>();
            HashSet<char> openingCharacters = new HashSet<char>() { '(', '{', '[' };
            HashSet<char> closingCharacters = new HashSet<char>() { ')', '}', ']' };
            Dictionary<char, char> parenthesesPairs = new Dictionary<char, char>(){
                {'(', ')'},
                {'[', ']'},
                {'{', '}'},
            };

            foreach (char letter in s)
            {
                if (openingCharacters.Contains(letter))
                {
                    openingsStack.Push(letter);
                }
                else if (closingCharacters.Contains(letter))
                {
                    if (openingsStack.Count == 0)
                    {
                        return false;
                    }
                    char lastOpening = openingsStack.Pop();
                    if (parenthesesPairs[lastOpening] != letter)
                    {
                        return false;
                    }
                }

            }

            if (openingsStack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}