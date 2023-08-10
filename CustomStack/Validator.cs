namespace CustomStack
{
    public class Validator
    {
        public bool IsValid(Char[] chars)
        {
            CustomStack<char> stack = new CustomStack<char>();
            char topOfStack = '0';
            for (int i = 0; i < chars.Length; i++)
            {
                if (stack.HasItem() == true)
                topOfStack= stack.Peek();

                if ((chars[i]==')' && topOfStack=='(')
                    || (chars[i] == ']' && topOfStack == '[')
                    || (chars[i] == '}' && topOfStack == '{'))
                    stack.Pop();
                else
                    stack.Push(chars[i]);
            }
            if (stack.HasItem())
                return false;
            else 
               return true;
        }
    }
}
