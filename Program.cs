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
            string[] answers = {"aroha","kakariki","enoho", "awa", "haka", "waka", "pango or mango", "maunga","papa", "whaea"};

            string[] questions = 
                
               {"\nQ1. What is 'love' in Te Reo Maori?",
                "\nQ2. What is 'green' in Te Reo Maori?",
                "\nQ3. What is the phrase 'sit down' in Te Reo Maori?",
                "\nQ4. What is 'river' in Te Reo Maori?",
                "\nQ5. What is the name of the popular Maori dance that rugby players do before they start their game?",
                "\nQ6. What is the word for 'boat' in Te Reo Maori?",
                "\nQ7. What is the colour 'black' in Te Reo Maori?",
                "\nQ8. What is 'mountain' in Te Reo Maori?",
                "\nQ9. What is 'father' in Te Reo Maori?",
                "\nQ10. What is 'mother' in Te Reo Maori?"};


            Console.WriteLine(questions[0]);
            Console.ReadLine();

            if Console.ReadLine()= answers[1];

            Console.WriteLine(questions[1]);
            Console.ReadLine();

            Console.WriteLine(questions[2]);
            Console.ReadLine();

            Console.WriteLine(questions[3]);
            Console.ReadLine();

            Console.WriteLine(questions[4]);
            Console.ReadLine();

            Console.WriteLine(questions[5]);
            Console.ReadLine();

            Console.WriteLine(questions[6]);    
            Console.ReadLine();

            Console.WriteLine(questions[7]);
            Console.ReadLine();

            Console.WriteLine(questions[8]);
            Console.ReadLine();

            Console.WriteLine(questions[9]);
            Console.ReadLine();

            Console.WriteLine(questions[10]);
            Console.ReadLine();

        }
    }
}