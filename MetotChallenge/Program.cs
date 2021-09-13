using System;

namespace MetotChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string frank= "Frank";
            string zoe = "Zoe";
            string john = "John";
            GF(frank, zoe, john);

        } public static void GF(string friendName1, string friendName2, string friendName3)
        {
            Console.WriteLine("Hello {0}, my friend!", friendName1);
            Console.WriteLine("Hello {0}, my friend!", friendName2);
            Console.WriteLine("Hello {0}, my friend!", friendName3);

        }
    }
}
