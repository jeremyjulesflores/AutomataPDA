namespace AutomataPDA.Checker
{
    public class BracketChecker : PDAChecker
    {
        public bool check(string input)
        {
            //initialize variables
            string open = "{([";
            string close = "})]";
            Stack<char> stack = new Stack<char>();
            char[] chars = input.ToCharArray();
            
            foreach(char c in chars)
            {
                //check if character is an open bracket then push
                if (open.Contains(c))
                {
                    stack.Push(c);
                }
                //check if it is a close bracket then pop then compare
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
                //if not open nor close bracket then auto return false
                else
                {
                    return false;
                }
            }
            //check first if stack is empty, if not, return false
            if(stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
