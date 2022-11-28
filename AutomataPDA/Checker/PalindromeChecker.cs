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
            char[] chars = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            if (chars.Length %2 != 0)
            {
                var charList = chars.ToList();
                charList.RemoveAt((chars.Length/2));
                chars = charList.ToArray<char>();
            }
            foreach(char c in chars)
            {
                if (!stack.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
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
