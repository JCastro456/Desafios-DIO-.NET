using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numeros = 1;
            
            for (int i = 1; i <= n; i++) {
              
                 Console.WriteLine($"{i} {i * i}  {i * i * i}",  numeros++);
            }       
        
        } 
    }
}