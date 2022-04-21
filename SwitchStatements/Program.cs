using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! Tell me your favorite subject in school!");
            var response = Console.ReadLine();
            switch (response)
            {
                case "Math" or "math":
                    Console.WriteLine("You like numbers that much?");
                    break;
                case "Art" or "art" :
                    Console.WriteLine("Oooh nice, I love art too!");
                    break;
                case "Science" or "science":
                    Console.WriteLine("Okay Elon, make sure you give me a Telsa.");
                    break;
                case "Spanish" or "spanish":
                    Console.WriteLine("Sorry, I don't speak Korean. Wait, your from Korea?? <.<");
                    break;
                default:
                    Console.WriteLine("Never heard of that one, but at the same time, I've never been to school.");
                    break;
            }
        }
    }
}
