using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataPDA.Checker
{
    public class PalindromeChecker : PDAChecker
    {
        public bool check(string input)
        {
            //initialize variables
            char[] chars = input.ToCharArray();
            Stack<char> stack = new Stack<char>();

            //check if odd
            if (chars.Length %2 != 0)
            {
                //if odd remove middle element
                var charList = chars.ToList();
                charList.RemoveAt((chars.Length/2));
                chars = charList.ToArray<char>();
            }
            foreach(char c in chars)
            {
                //push if character is not yet in stack
                if (!stack.Contains(c))
                {
                    stack.Push(c);
                }
                else // if character is in stack already
                {
                    // check if top of stack is not equals to character
                    if(stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
