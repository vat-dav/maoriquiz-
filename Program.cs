using System;

namespace maoriquiz_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int intnum;


            Console.WriteLine("Welcome to my Te Reo Maori Quiz!");
            Console.WriteLine("\nWhat is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"What level would you like try "+name+"\n\n1.) Beginner\n2.) Intermediate\n3.) Advanced ?");
            string strrnum = Console.ReadLine();
            
            intnum = Convert.ToInt32(strrnum);
            
            if (intnum == 1)
            {

            }



        }
    }
}