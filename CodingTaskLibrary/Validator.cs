using System;
using System.Text.RegularExpressions;

namespace CodingTaskLibrary
{
    public static class Validator
    {
        /// <summary>
        /// validate if string contain any brakets
        /// </summary>
        /// <param name="myinput">string</param>
        /// <returns>boolean</returns>
        public static bool ContainBrakets(string myinput)
        {
            bool result = false;
            foreach (char brakets in myinput.ToCharArray().ToList())
            {
                if (brakets.Equals('{') || brakets.Equals('}')
                    || brakets.Equals(')') || brakets.Equals('(')
                    || brakets.Equals('{') || brakets.Equals('}'))
                {
                    result = true;
                    break;
                }
            }
            
            return result;
        }

        /// <summary>
        /// return if an string contain brakets balance.
        /// </summary>
        /// <param name="myinput">string</param>
        /// <returns>boolean</returns>
        public static bool IsBalance(string myinput) {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (char c in myinput)
                {
                    if (bracketPairs.Keys.Contains(c))
                    {
                        brackets.Push(c);
                    }
                    else
                        if (bracketPairs.Values.Contains(c))
                        {
                            // check if the closing bracket matches the 'latest' 'opening' bracket
                            if (c == bracketPairs[brackets.First()])
                            {
                                // Removes and returns the object at the top of the Stack.
                                brackets.Pop();
                            }
                            else
                                // if not, its an unbalanced string
                                return false;
                        }
                        else
                            // continue looking
                            continue;
                }
            }
            catch
            {
                // an exception will be caught in case a closing bracket is found, 
                // before any opening bracket.
                // that implies, the string is not balanced. Return false
                return false;
            }

            return brackets.Count() == 0 ? true : false;
        }
    }
}