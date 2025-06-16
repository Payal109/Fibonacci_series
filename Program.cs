namespace Fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Finbonacci series---");
            int num = 8;
            int a = 0;
            int b = 1;
            int c;
            Console.Write(a + "   " + b);
            while (num > 0)
            {
                c = a + b;
                Console.Write("   " + c + "   ");
                a = b; b = c;
                num--;
            }
        }
    }
}
