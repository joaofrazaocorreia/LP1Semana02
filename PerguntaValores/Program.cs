using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert height:");
            string height= Console.ReadLine();

            Console.WriteLine("Please insert radius:");
            string radius= Console.ReadLine();

            int a = int.Parse(height);
            int r = int.Parse(radius);
            double pi = 3.1415926;

            double volume = pi * (r*r) * a;
            Console.WriteLine("The cylinder's volume is "+volume+".");

            double surfc_area = 2 * pi * r * (r+a);
            Console.WriteLine("The cylinder's surface area is "+surfc_area+".");
        }
    }
}
