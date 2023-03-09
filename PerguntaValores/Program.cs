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

            double volume = Math.PI * (r*r) * a;
            Console.WriteLine("The cillinder's volume is "+volume+".");

            
        }
    }
}
