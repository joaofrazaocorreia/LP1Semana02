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

            double volume = Math.PI * Math.Pow(r,2) * a;
            Console.WriteLine("The cylinder's volume is "+volume+".");

            double surfc_area = 2 * Math.PI * r * (r+a);
            Console.WriteLine("The cylinder's surface area is "+surfc_area+".");
        }
    }
}
