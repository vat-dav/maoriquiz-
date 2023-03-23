﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;

namespace maoriquiz_
{
    internal class Program
    {
        static string name, points;
        static void Main(string[] args)
        {
            string s2_uni = "\u263A"; // unicode code for s2


            //welcoming user to quiz
            Console.WriteLine($"Welcome to my Te Reo Maori Quiz " + s2_uni + " !");

            //prompts user for name
            Console.WriteLine("\nWhat is your name?\n");
            name = Console.ReadLine();

            //clears console visually
            Console.Clear();

            //navigates to mainmenu method
            mainmenu();

        }
        static void mainmenu()
        {
            //welcomes viewer again using name to the main menu
            Console.WriteLine($"Welcome " + name + "!");

            //asks user for what level they would like to try
            Console.WriteLine($"\nWhat level would you like try " + name + "?\n\n1.) Beginner\n2.) Intermediate\n3.) Advanced\n");
            string level = Console.ReadLine();


            //converts string to int
            int intnum = Convert.ToInt32(level);


            if (intnum == 1)
            {
                //navigates to beginner level
                Beginner();

            }

            else if (intnum == 2)

            {
                //navigates to intermediate level
                Intermediate();

            }

            if (intnum == 3)

            {
                //navigates to advanced level
                Advanced();

            }

        }


        static void Beginner()
        {
            //clears console visually
            Console.Clear();

            //informs the viewer they have chosen the beginner level
            Console.WriteLine("you have chosen the Beginner level!\n");




            //array for answers worded answers for reference (may delete later)
            string[] answers = { "aroha", "kakariki", "enoho", "awa", "haka", "waka", "pango or mango", "maunga", "papa", "whaea" };

            //array for letter answers
            string[] letteranswers = { "a", "b", "a", "c", "d", "a", "c", "b", "a", "c" };

            //array for questions
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


            //begins loop for beginner questions

            for (int i = 0; i < questions.Length; i++)
            {
                //clears console visually
                Console.Clear();

                //displays the question from the array
                Console.WriteLine(questions[i]);

                //reads what the user inputted
                letteranswers[i] = Console.ReadLine();

                //if answer is correct as per parallel array, then prompts user saying that they are correct
                if (letteranswers[i] == letteranswers[i])
                {
                    Console.WriteLine("\ncongratulations! you're right :)");

                    
                }

                //if answer is incorrect as per parallel array, then prompts user saying that they are incorrect
                else
                {
                    Console.WriteLine("\noh no! you're wrong :(");

                    

                    Console.WriteLine(points);

                    //end of level method
                }
            }
        }

        static void Intermediate()
        {

        //clears console visually
        Console.Clear();

        //informs the viewer that they have chosen the intermediate level
        Console.WriteLine("you have chosen the Intermediate level!");

        //end of level method
        }


        static void Advanced()
        {

        //clears console visually
        Console.Clear();

        //informs the viewer that they have chosen the advanced level
        Console.WriteLine("you have chosen the Advanced level!");

        }



        }
    }



    

