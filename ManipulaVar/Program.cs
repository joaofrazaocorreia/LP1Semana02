using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            Console.WriteLine(x);

            int y = 6;
            int result = x++ * y++;
            Console.WriteLine(args[0]+"++ times "+y+"++ equals "+result);
        }
    }
}
