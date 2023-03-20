using System;
using System.ComponentModel.Design;

namespace maoriquiz_
{
    internal class Program
    {
        static string name, mark ;
        static void Main(string[] args)
        {

           

            Console.WriteLine("Welcome to my Te Reo Maori Quiz!");
            Console.WriteLine("\nWhat is your name?");
            name = Console.ReadLine();


            Console.Clear();

            mainmenu();


        }
        static void mainmenu()
        {

            Console.WriteLine($"Welcome " + name + "!");
            Console.WriteLine($"\nWhat level would you like try " + name + "?\n\n1.) Beginner\n2.) Intermediate\n3.) Advanced");
            string level = Console.ReadLine();
            int intnum = Convert.ToInt32(level);
        
       
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
            
        }
        static void Beginner()
        {
            Console.Clear();
            Console.WriteLine("you have chosen the Beginner level!");

            BeginnerQuestions();
        }

        static void Intermediate()
        {
            Console.Clear();
            Console.WriteLine("you have chosen the Intermediate level!");


        }

        static void Advanced()
        {
            Console.Clear();
            Console.WriteLine("you have chosen the Advanced level!");
        
        }

        static void BeginnerQuestions()
        {
            Console.WriteLine("\nQ1.) What is love in Te Reo Maori?");
        
        }
    }
}