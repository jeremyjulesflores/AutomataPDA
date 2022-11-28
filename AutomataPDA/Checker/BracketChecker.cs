namespace AutomataPDA.Checker
{
    public class BracketChecker : PDAChecker
    {
        public bool check(string input)
        {
            string open = "{([";
            string close = "})]";
            Stack<char> stack = new Stack<char>();
            char[] chars = input.ToCharArray();
            
            foreach(char c in chars)
            {
                if (open.Contains(c))
                {
                    stack.Push(c);
                }
                else if (close.Contains(c))
                {
                    var check = stack.Pop();

                    switch (check)
                    {
                        case '{':
                            if (c != '}')
                                return false;
                                   
                            break;
                        case '[':
                            if(c != ']')
                                return false;
                            break;
                        case '(':
                            if(c != ')')
                                return false;
                            break;
                        default:
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            if(stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
