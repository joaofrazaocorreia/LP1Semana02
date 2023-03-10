using System;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = Convert.ToInt32(args[0]);
            int line=1;
            string line_text = "";

            while (line <= amount)
            {
                line_text="#";

                if (line==1 || line==amount)
                {
                    for (int x=1; x<amount; x++)
                    {
                        line_text+= "#";
                    }
                }

                else
                {
                    for (int x=1; x<=amount; x++)
                    {
                        if (x==line-1 || x==amount-line)
                        {
                            line_text+="X";
                        }

                        else if (x==amount-1)
                        {
                            line_text+= "#";
                        }

                        else
                        {
                            line_text+= " ";
                        }
                            
                    }
                }
                Console.WriteLine(line_text);
                line++;
            }
        }
    }
}
