namespace ReverseString
{
    public class Program
    {
        public static void Main()
        {
            string input = "Hello, World!";
            string reversed = "";

            for (int i = input.Length -1 ; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine(reversed);
        }
    }

}