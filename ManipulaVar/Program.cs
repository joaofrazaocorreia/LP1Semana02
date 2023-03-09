using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            int og_x = x;
            Console.WriteLine(og_x);

            int result1= x++ + x++;
            Console.WriteLine(og_x+"++ plus "+og_x+"++ equals "+result1);

            x = Convert.ToInt32(args[0]);
            int result2= --x + --x;
            Console.WriteLine("--"+og_x+" plus --"+og_x+" equals "+result2);
        }
    }
}
