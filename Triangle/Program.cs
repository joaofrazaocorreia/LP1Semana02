using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int line_amount = Convert.ToInt32(args[0]);
            string character = args[1];

            int line=1;
            string line_text = "";

            while (line<=line_amount)
            {        
                line_text += character;

                Console.WriteLine(line_text);
                line++;
            }
        }
    }
}
