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

            int num = 0;
            Console.Clear();

            Console.WriteLine($"What level would you like try "+name+"?\n\n1.) Beginner\n2.) Intermediate\n3.) Advanced");
            string strnum = Console.ReadLine();
            
            intnum = Convert.ToInt32(strnum);

            if (intnum == 1)
            {
                Beginner();

            }

            else if (intnum == 2)

            {
                Intermediate();
            
            }
            
            if (intnum == 3)

            {
                Advanced();
            
            }










            static void Beginner()
            {
               

            }
            
            static void Intermediate()
            {


            }
            
            static void Advanced()
            {


            }
        }
    }
}