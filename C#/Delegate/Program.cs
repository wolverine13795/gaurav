using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    delegate void Arith(int a, int b);
    internal class Program
    {
        public static void add(int a, int b)
        {
            Console.Write(a + b);
        }
        public static void product(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Arith art = new Arith(add);
            art(10, 20);
            Console.WriteLine();
            art = product;
            art(20,30);
        }
    }
}