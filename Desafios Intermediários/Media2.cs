using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            media = (((A*2) + (B*3) + (C*5))/10);
            Console.WriteLine("MEDIA = " + Math.Round(media,1));
            Console.ReadKey();
        }
    }
}