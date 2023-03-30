using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace maoriquiz_
{
    internal class Program
    {
        static string name;
        static int points;
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
            string[] answers = { "aroha", "kakariki", "enoho", "awa", "haka", "waka", "pango or mangu", "maunga", "papa", "whaea" };

            //array for letter answers
            string[] letteranswers = { "a", "b", "a", "c", "d", "a", "a", "b", "a", "d" };

            //array for questions
            string[] questions =

            {"Q1. What is 'love' in Te Reo Maori?\n\na.) aroha\nb.) tangata\nc.) pango\nd.) awa","Q2. What is 'green' in Te Reo Maori?\n\na.) Pango\nb.) Kakariki\nc.) Whero\nd.) Kowhai","Q3. What is the phrase 'sit down' in Te Reo Maori?\n\na.) Enoho\nb.) Tu ki runga\nc.) Haere Ra\nd.) Haera Mai","Q4. What is 'river' in Te Reo Maori?\n\na.) Waka\nb.) Maunga\nc.) Awa\nd.) Maka","Q5. What is the name of the popular Maori dance that rugby players do before they start their game?\n\na.) Mala\nb.) Kaka\nc.) Waka\nd.) Haka","Q6. What is the word for 'boat' in Te Reo Maori?\n\na.) Waka\nb.) Haka\nc.) Kikorangi\nd.) Kaka","Q7. What is the colour 'black' in Te Reo Maori?\n\na.) Pango\nb.) Kikorangi\nc.) Mango\nd.) Kowhai","Q8. What is 'mountain' in Te Reo Maori?\n\na.) Awa\nb.) Maunga\nc.) Waka\nd.) Maka","Q9. What is 'father' in Te Reo Maori?\n\na.) Papa\nb.) Kaka\nc.) Mama\nd.) Whaea","Q10. What is 'mother' in Te Reo Maori?\n\na.) Maui\nb.) Ma\nc.) Mama\nd.) Whaea"};


            //begins loop for beginner questions

            for (int i = 0; i < questions.Length; i++)
            {
                //gives user time to read console info
                Thread.Sleep(2000);

                //clears console visually
                Console.Clear();

                //displays the question from the array
                Console.WriteLine(questions[i] + "\n");

                //reads what the user inputted

                string useranswers1 = Console.ReadLine().ToLower();


                //if answer is correct as per parallel array, then prompts user saying that they are correct
                if (useranswers1 == letteranswers[i])
                {

                    points++;

                    //displays that user is correct
                    Console.WriteLine("\ncongratulations! you're right :)");

                    //displays points for user
                    Console.WriteLine("\nyour current score is:" + points + "/10");

                    //gives user time to read console info
                    Thread.Sleep(1000);
                }

                //if answer is incorrect as per parallel array, then prompts user saying that they are incorrect
                else
                {
                    Console.WriteLine("\noh no! you're wrong :(");


                    //displays points for user
                    Console.WriteLine("\nyour current score is:" + points + "/10");

                    //gives user time to read console info
                    Thread.Sleep(1000);

                    Console.WriteLine("you have chosen the beginner level!");


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

                //array for answers worded answers for reference (may delete later)
                string[] answers = { "To try", "Hello and Welcome", "Aoraki", "Family tree or genealogy", "Tautoru", "To eat", "Kereru", "Song", "Hello or thank you", "Marae" };

                //array for letter answers
                string[] letteranswers = { "a", "a", "b", "a", "b", "b", "c", "a", "a", "a" };

                //array for questions
                string[] questions =

                {"Q1. What does the word 'tāmātaki' mean in te reo Māori?\na.) To try\nb.) To cook\nc.) To swim\nd.) To sing\n","Q2. Which of the following is the correct translation for the phrase 'nau mai, haere mai'?\na.) Hello and welcome\nb.) Goodbye and thank you\nc.) Please and thank you\nd.) Yes and no\n","Q3. What is the Māori name for New Zealand's highest mountain?\na.) Taranaki\nb.) Aoraki\nc.) Tarawera\nd.) Tongariro\n","Q4. What does the word 'whakapapa' mean in te reo Māori?\na.) Family tree or genealogy\nb.) To eat or consume\nc.) To dance or perform\nd.) To read or write\n","Q5. What is the Māori name for the Southern Cross constellation?\na.) Matariki\nb.) Tautoru\nc.) Whakaahu\nd.) Puanga\n","Q6. Which of the following is the correct translation for the word 'kai'?\na.) To swim\nb.) To eat\nc.) To sleep\nd.) To dance\n","Q7. What is the Māori name for the native bird commonly known as the wood pigeon?\na.) Ruru\nb.) Tui\nc.) Kereru\nd.) Piwakawaka\n","Q8. What does the word 'waiata' mean in te reo Māori?\na.) Song\nb.) Dance\nc.) Story\nd.) Ceremony\n","Q9. Which of the following is the correct translation for the phrase 'kia ora'?\na.) Hello or thank you\nb.) Goodbye or see you later\nc.) Please or excuse me\nd.) Yes or no\n","Q10. What is the Māori name for the traditional Māori meeting house?\na.) Marae\nb.) Wharenui\nc.) Waka\nd.) Pātaka\n"};


                //begins loop for beginner questions

                for (int i = 0; i < questions.Length; i++)
                {
                    //gives user time to read console info
                    Thread.Sleep(2000);

                    //clears console visually
                    Console.Clear();

                    //displays the question from the array
                    Console.WriteLine(questions[i] + "\n");

                    //reads what the user inputted

                    string useranswers1 = Console.ReadLine().ToLower();


                    //if answer is correct as per parallel array, then prompts user saying that they are correct
                    if (useranswers1 == letteranswers[i])
                    {

                        points++;

                        //displays that user is correct
                        Console.WriteLine("\ncongratulations! you're right :)");

                        //displays points for user
                        Console.WriteLine("\nyour current score is:" + points + "/10");

                        //gives user time to read console info
                        Thread.Sleep(1000);
                    }

                    //if answer is incorrect as per parallel array, then prompts user saying that they are incorrect
                    else
                    {
                        Console.WriteLine("\noh no! you're wrong :(");


                        //displays points for user
                        Console.WriteLine("\nyour current score is:" + points + "/10");

                        //gives user time to read console info
                        Thread.Sleep(1000);



                        //end of level method

                        //end of level method
                    }

                }
            Console.WriteLine("HI");
                  redo("beg");

            }


                static void Advanced()
                {

                    //clears console visually
                    Console.Clear();

                    //informs the viewer that they have chosen the advanced level
                     

                }

                static void redo(string level)
                {
                    Console.WriteLine("do you want to redo level");
                    string redoans = Console.ReadLine();

                    if( redoans =="Y")

                    {
                        Console.WriteLine("welocme back " + name);
                        if(level == "ad")
                        {
                            Advanced();
                        }
                        if (level == "inter")
                        {
                            Intermediate();
                        }
                        if (level == "beg")
                        {
                            Beginner();
                        }





                    }
                    else
                    {
                        Console.WriteLine("good bye");
                        return;
                    }
                }


            }
        }

    






