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

        static int points;




            static void Main(string[] args)
        {
            // unicode code for s2
            string s2_uni = "\u263A";


            //welcoming user to quiz
            Console.WriteLine($"Welcome to Vatsal's Te Reo Maori Quiz, questions will be asked in a multichoice manner (a, b, c, or d.) \nanswer using the associated key to the correct answer.\n\nEnjoy" + s2_uni + " !");

            //gives user time to process information slowly
            Thread.Sleep(1500);

            //prompts user for name
            Console.WriteLine("\nWhat is your name?\n");

            //declares that the name of the user is what they will enter
            string userName = Console.ReadLine();

            //clears console visually 
            Console.Clear();

            //navigates to mainmenu method
            mainmenu(userName);

        }
        static void mainmenu(string userName)

        {
            //clears console visually
            Console.Clear();

            //welcomes viewer again using name to the main menu
            Console.WriteLine($"Welcome " + userName + "!");

            //asks user for what level they would like to try
            Console.WriteLine($"\nWhat level would you like try " + userName + "?\n\n1.) Beginner\n2.) Intermediate\n3.) Advanced\n");
            string level = Console.ReadLine();


            //converts string to int
            int intnum = Convert.ToInt32(level);


            if (intnum == 1)
            {
                //navigates to beginner level
                Beginner(userName);

            }

            else if (intnum == 2)

            {
                //navigates to intermediate level
                Intermediate(userName);

            }

            if (intnum == 3)

            {
                //navigates to advanced level
                Advanced(userName);

            }
        }






        static void Beginner(string userName)
        {
            //ensures the points reset to 0
            points = 0;

            //clears console visually
            Console.Clear();

            //informs the viewer they have chosen the beginner level
            Console.WriteLine("you have chosen the Beginner level!\n");

            //array for multichoice letter answers
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
                    //adds one point to the users total points for the level
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

                }


            }
            //navigates to redo method in which user can redo the quiz if they would like to
            redo(userName);

            //end of level method


        }

        
        static void Intermediate(string userName)
        {
            //ensures the points reset to 0
            points = 0;

            //clears console visually
            Console.Clear();

            //informs the viewer that they have chosen the intermediate level
            Console.WriteLine("you have chosen the Intermediate level!");


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
                    //adds one point to the users total points for the level
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

                }
            }

            //navigates to redo method in which user can redo the quiz if they would like to
                    redo(userName);

            //end of level method

        }
        

        static void Advanced(string userName)

        {
            //ensures the points reset to 0
            points = 0;

            //clears console visually
            Console.Clear();

            //informs the viewer that they have chosen the advanced level
            Console.WriteLine("you have chosen the Advanced level!");

            //array for answers worded answers for reference (may delete later)
            string[] answers = { "People of the land", "Rekohu", "Matariki", "Guardianship or Stewardship", "Te Moana-o-Kupe", "Song or chant", "Piopiotahi", "Kakapo", "Kā Tiritiri-o-te-Moana", "Spirit or soul" };

            //array for letter answers
            string[] letteranswers = { "a", "c", "a", "a", "d", "a", "a", "a", "d", "a" };

            //array for questions
            string[] questions =

            {"Q1.) What does the word 'tangata whenua' mean in te reo Māori?\n\na.) People of the land\nb.) People of the sea\nc.) People of the sky\nd.) People of the mountain\n","Q2.) What is the Māori name for the Chatham Islands?\n\na.) Rangitoto\nb.) Whakaari\nc.) Rekohu\nd.) Motiti\n","Q3.) What is the Māori name for the Pleiades star cluster?\n\na.) Matariki\nb.) Puanga\nc.) Atutahi\nd.) Te Poutū-te-rangi\n","Q4.) What does the word 'kaitiakitanga' mean in te reo Māori?\n\na.) Guardianship or stewardship\nb.) Leadership or authority\nc.) Harmony or balance\nd.) Respect or reverence\n","Q5.) What is the Māori name for the Cook Strait?\n\na.) Te Tai-o-Rehua\nb.) Te Moana-nui-a-Toi\nc.) Te Moana-o-Raukawa\nd.) Te Moana-o-Kupe\n","Q6.) What does the word 'waiata' mean in te reo Māori?\n\na.) Song or chant\nb.) Dance or performance\nc.) Story or legend\nd.) Art or craft\n","Q7.) What is the Māori name for the Milford Sound?\n\na.) Piopiotahi\nb.) Whangaparapara\nc.) Ohiwa\nd.) Aotea\n","Q8.) What colour is the 'kakapo' bird in te reo Māori?\n\na.) Kakariki\nb.) Kikorangi\nc.) Pango\nd.) Kowhai\n","Q9.) What is the Māori name for the Southern Alps?\n\na.) Kaimai Range\nb.) Tararua Range\nc.) Kaikoura Range\nd.) Kā Tiritiri-o-te-Moana\n","Q10.) What does the word 'wairua' mean in te reo Māori?\n\na.) Spirit or soul\nb.) Mind or consciousness\nc.) Heart or emotion\nd.) Breath or life force\n"};


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
                    //adds one point to the users total points for the level
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

                }
            }
                    //navigates to redo method in which user can redo the quiz if they would like to
                    redo(userName);

                //end of level method
            }

            static void redo(string userName)
            {
                //stores the input which will be received by the user regarding whether they want to redo the quiz
                string redoquizans;

                //clears console for the viewer
                Console.Clear();

                //informs the user what their final score was
                Console.WriteLine("" + userName + ", your final score was " + points + "!");

                //asks user if they would like to redo the quiz
                Console.WriteLine("would you like to redo quiz?\n\na.) yes\nb.) no");

                //tells program that the variable which the user inputs should be stored in the "redoquizans" string
                redoquizans = Console.ReadLine();

                //if user would like to redo the quiz, they will type "a" and that will lead them to the main menu where they can choose which level they would like to do
                if (redoquizans == "a")
                {
                    mainmenu(userName);


                }
                //if user would not like to redo the quiz, they will type "b" and that will prompt them a message thanking them for playing the quiz
                if (redoquizans == "b")
                {
                    Console.WriteLine("thank you" + userName + "for playing Vatsal's Te Reo Maori Quiz! Have a great day :>");




                }
            }

        }
    }




//fix points system,






