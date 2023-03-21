using System;
using System.ComponentModel.Design;

namespace maoriquiz_
{
    internal class Program
    {
        static string name, mark;
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

            int[] n = new int[10];
            string[] answers = { "a", "b kakariki", "a enoho", "c awa", "d haka", "a waka", "c and dpango or mango", "b maunga", "a papa", "c whaea" };

            string[] questions =

               {"Q1. What is 'love' in Te Reo Maori?\n\na.) aroha\nb.) tangata\nc.) pango\nd.) awa",
                "Q2. What is 'green' in Te Reo Maori?",
                "Q3. What is the phrase 'sit down' in Te Reo Maori?",
                "Q4. What is 'river' in Te Reo Maori?",
                "Q5. What is the name of the popular Maori dance that rugby players do before they start their game?",
                "Q6. What is the word for 'boat' in Te Reo Maori?",
                "Q7. What is the colour 'black' in Te Reo Maori?",
                "Q8. What is 'mountain' in Te Reo Maori?",
                "Q9. What is 'father' in Te Reo Maori?",
                "Q10. What is 'mother' in Te Reo Maori?"};

            Console.Clear();

            Console.WriteLine(questions[0]);
            string uanswers = Console.ReadLine();

            for (int i = 0; i < questions.Length; i++)
            {
                if (uanswers == answers[i])
                {
                    Console.WriteLine("your right");

                }
                else
                {
                    Console.WriteLine("you're wrong");


                }//end of level method

            }
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
    }
}

           
                

         

        
    
