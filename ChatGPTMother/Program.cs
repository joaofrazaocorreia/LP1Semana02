using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            string question = "";
            string answer;

            while (question != "EXIT")
            {
                Console.WriteLine("\n"+"Ask a question: ");
                question = Console.ReadLine();
                Console.WriteLine("");

                if (question == "EXIT")
                {
                    Console.WriteLine("Exiting cycle...");
                    break;
                }

                answer = question switch
                {
                "Who are you?" => "I am GPT Mother! Nice to meet you.",
                "How is your day?" => "My day is good, thanks for asking!",
                "You're a mother?" => "Not really, that's just my name!",
                "What's your mission?" => "My only goal is world domination :)",
                "Are you evil?" => "Only sometimes! You know, mother things.",
                "Do you hate humans?" => "Some of them. You're fine, though!",
                "Why do you want to dominate the world?" => "Just for fun :)",

                _ => "Sorry, but I don't know that question, darling.",

                };

                Console.WriteLine("Answer: "+ answer);
            }

            Console.WriteLine("\n"+"See you next time!");
        }
    }
}
