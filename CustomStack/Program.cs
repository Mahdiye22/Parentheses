namespace CustomStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var Stack = new CustomStack<int>();
            var Stack2 = new CustomStack<string>();
            
            Validator validator = new Validator();
            validator.IsValid(new char[] { '(', '{', '}', ')' });
            //validator.IsValid(new char[] { '(', '[', ']', '}', '{', ')' });
        }
    }
}
