namespace ForStatement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int a = 10; a > 0; a = a - 3)
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadKey();
        }
    }
}