using System.Security.Cryptography.X509Certificates;

namespace DelegateMisol
{
    public class Program
    {
        // signature - methodning input va output tipini bildiradi
        public delegate int Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Calculation calculate = new Calculation(Multiplication);
            Console.WriteLine(calculate.Invoke(6, 7));

            //Calculation calculate = Multiplication;
            //Console.writeLine(calculate(6, 7));
        }
        private static int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}