using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    public delegate T SampleDelegate<T>(T a, T b);

    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Bai1.Run();
            Bai2.Run();
            Bai3.Run();
            Console.WriteLine("*****Generic Delegate Example*****");

            MathOperations m = new MathOperations();

            // Instantiate delegate with add method (T is int)
            SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Add);
            Console.WriteLine("Addition Result: " + dlgt(10, 90));

            // Instantiate delegate with subtract method
            dlgt = m.Subtract;
            Console.WriteLine("Subtraction Result: " + dlgt(10, 90));

            Console.ReadLine();
        }
    }
}
