using System;
namespace TESTE {
    class Program {
      static void Main(string[] args){
        
        int N = int.Parse(Console.ReadLine());
        
        int primeiro = 1;
            
        for (int i = 1; i <= N; i++) { 
           for (int y = 1; y <= 3; y++) 
           
              Console.Write(string.Format("{0} ", primeiro++));
              
        Console.WriteLine("PUM");
        primeiro++;
        }
      }     
    }
}