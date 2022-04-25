using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            
                Console.WriteLine(string.Format("{0}\tx\t{1}\t=\t{2}", i, n, n*i));
              
        }
    }
}