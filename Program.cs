using System.Diagnostics.Metrics;

namespace User_Reviews_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring Array 1 - Praise Phrases
            string[] reviews1 = new string[]
             {"This product is excelent.", "This is a great product.", "I use this product all thetime.", "This is the best product of this category."};

            //Declaring an array of 2 - commendable events
            string[] reviews2 = new string[]
             {"Now I feel better.", "I changed.", "It was a miracle.", "I can't believe it. Now I feelbetter.", "Try it yourself. I'm very greatful."};

            //Declaring arrays number 3 and 4 - names
            string[] firstNames = new string[] 
            { "Diana", "Petia", "Stela", "Keiti", "Elena" };

            string[] secondNames = new string[]
            {"Ivanova","Petrova","Nikolova","Popova"};

            //Random Number Generator
            Random rnd = new Random();

            //Display the result in the console
            Console.WriteLine("{0}{1}\n-- {2}{3}.", reviews1[rnd.Next(4)], reviews2[rnd.Next(5)], firstNames[rnd.Next(5)], secondNames[rnd.Next(4)]);
        }
    }
}