using System; 

namespace DIO1 {

  class Problem {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
        
        int n = int.Parse(v[0]);
        int l = int.Parse(v[1]);
        int p;
        
        p = (n * l);
        
       System.Console.Write($"{p}");
    }
  }
}