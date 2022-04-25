using System; 
 class DIO{
 
    static void Main(string[] args) {
		string[] input;

	      input = Console.ReadLine().Split(' ');
        int codigopeca1 = int.Parse(input[0]);
        int numeropeca1 = int.Parse(input[1]);
        double valorunit1 = double.Parse(input[2]);
     
 	      input = Console.ReadLine().Split(' ');
        int codigopeca2 = int.Parse(input[0]);
	      int numeropeca2  = int.Parse(input[1]);
        double valorunit2 = double.Parse(input[2]);

        double total = ((numeropeca1*valorunit1) + (numeropeca2*valorunit2));
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }
}
