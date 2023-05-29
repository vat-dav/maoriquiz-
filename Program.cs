namespace maoriquiz_
{   internal class Program
    {
        // globally declares point as a static variable
        static int points;

        // declares main method
        static void Main(string[] args)
        {
            bool redo = true;
            
            // array with Beginner Questions
            string[] begQuestions = {"Q1. What is 'love' in Te Reo Maori?\n\na.) aroha\nb.) tangata\nc.) pango\nd.) awa", "Q2. What is 'green' in Te Reo Maori?\n\na.) Pango\nb.) Kakariki\nc.) Whero\nd.) Kowhai", "Q3. What is the phrase 'sit down' in Te Reo Maori?\n\na.) Enoho\nb.) Tu ki runga\nc.) Haere Ra\nd.) Haera Mai", "Q4. What is 'river' in Te Reo Maori?\n\na.) Waka\nb.) Maunga\nc.) Awa\nd.) Maka",  "Q5. What is the name of the popular Maori dance that rugby players do before they start their game?\n\na.) Mala\nb.) Kaka\nc.) Waka\nd.) Haka", "Q6. What is the word for 'boat' in Te Reo Maori?\n\na.) Waka\nb.) Haka\nc.) Kikorangi\nd.) Kaka", "Q7. What is the colour 'black' in Te Reo Maori?\n\na.) Pango\nb.) Kikorangi\nc.) Mango\nd.) Kowhai",  "Q8. What is 'mountain' in Te Reo Maori?\n\na.) Awa\nb.) Maunga\nc.) Waka\nd.) Maka",  "Q9. What is 'father' in Te Reo Maori?\n\na.) Papa\nb.) Kaka\nc.) Mama\nd.) Whaea","Q10. What is 'mother' in Te Reo Maori?\n\na.) Maui\nb.) Ma\nc.) Mama\nd.) Whaea" };

            // array with Intermediate level Questions
            string[] intQuestions = { "Q1. What does the word 'tāmātaki' mean in te reo Māori?\n\na.) To try\nb.) To cook\nc.) To swim\nd.) To sing\n", "Q2. Which of the following is the correct translation for the phrase 'nau mai, haere mai'?\n\na.) Hello and welcome\nb.) Goodbye and thank you\nc.) Please and thank you\nd.) Yes and no\n", "Q3. What is the Māori name for New Zealand's highest mountain?\n\na.) Taranaki\nb.) Aoraki\nc.) Tarawera\nd.) Tongariro\n", "Q4. What does the word 'whakapapa' mean in te reo Māori?\n\na.) Family tree or genealogy\nb.) To eat or consume\nc.) To dance or perform\nd.) To read or write\n", "Q5. What is the Māori name for the Southern Cross constellation?\n\na.) Matariki\nb.) Tautoru\nc.) Whakaahu\nd.) Puanga\n", "Q6. Which of the following is the correct translation for the word 'kai'?\n\na.) To swim\nb.) To eat\nc.) To sleep\nd.) To dance\n", "Q7. What is the Māori name for the native bird commonly known as the wood pigeon?\n\na.) Ruru\nb.) Tui\nc.) Kereru\nd.) Piwakawaka\n", "Q8. What does the word 'waiata' mean in te reo Māori?\n\na.) Song\nb.) Dance\nc.) Story\nd.) Ceremony\n", "Q9. Which of the following is the correct translation for the phrase 'kia ora'?\n\na.) Hello or thank you\nb.) Goodbye or see you later\nc.) Please or excuse me\nd.) Yes or no\n", "Q10. What is the Māori name for the traditional Māori meeting house?\n\na.) Marae\nb.) Wharenui\nc.) Waka\nd.) Pātaka\n" };

            // array with Advanced level Questions
            string[] advQuestions = { "Q1.) What does the word 'tangata whenua' mean in te reo Māori?\n\na.) People of the land\nb.) People of the sea\nc.) People of the sky\nd.) People of the mountain\n", "Q2.) What is the Māori name for the Chatham Islands?\n\na.) Rangitoto\nb.) Whakaari\nc.) Rekohu\nd.) Motiti\n", "Q3.) What is the Māori name for the Pleiades star cluster?\n\na.) Matariki\nb.) Puanga\nc.) Atutahi\nd.) Te Poutū-te-rangi\n", "Q4.) What does the word 'kaitiakitanga' mean in te reo Māori?\n\na.) Guardianship or stewardship\nb.) Leadership or authority\nc.) Harmony or balance\nd.) Respect or reverence\n", "Q5.) What is the Māori name for the Cook Strait?\n\na.) Te Tai-o-Rehua\nb.) Te Moana-nui-a-Toi\nc.) Te Moana-o-Raukawa\nd.) Te Moana-o-Kupe\n", "Q6.) What does the word 'waiata' mean in te reo Māori?\n\na.) Song or chant\nb.) Dance or performance\nc.) Story or legend\nd.) Art or craft\n", "Q7.) What is the Māori name for the Milford Sound?\n\na.) Piopiotahi\nb.) Whangaparapara\nc.) Ohiwa\nd.) Aotea\n", "Q8.) What colour is the 'kakapo' bird in te reo Māori?\n\na.) Kakariki\nb.) Kikorangi\nc.) Pango\nd.) Kowhai\n", "Q9.) What is the Māori name for the Southern Alps?\n\na.) Kaimai Range\nb.) Tararua Range\nc.) Kaikoura Range\nd.) Kā Tiritiri-o-te-Moana\n", "Q10.) What does the word 'wairua' mean in te reo Māori?\n\na.) Spirit or soul\nb.) Mind or consciousness\nc.) Heart or emotion\nd.) Breath or life force\n" };

            // array with Beginner level Answers
            string[] begAnswers = { "a", "b", "a", "c", "d", "a", "a", "b", "a", "d" };

            // array with Intermediate level Answers
            string[] intAnswers = { "a", "a", "b", "a", "b", "b", "c", "a", "a", "a" };

            // array with Advanced level Answers
            string[] advAnswers = { "a", "c", "a", "a", "d", "a", "a", "a", "d", "a" };

            // unicode for s2 (the emoji)
            string s2_uni = "\u263A";

            // changes visual colour of text to dark cyan because it is a popular colour
            Console.ForegroundColor= ConsoleColor.DarkCyan;

            // welcomes user to quiz and provides information regarding how the questions will be asked, and how to answer them
            Console.WriteLine("Welcome to Vatsal's Te Reo Maori Quiz, questions will be asked in a multichoice manner (a, b, c, or d.) \nanswer using the associated key to the correct answer.\n");

            // has a delay to let the user read the opening statement
            Thread.Sleep(1000);

            // friendly opening to quiz
            Console.WriteLine("\nEnjoy " + s2_uni + " !");

            // gives user time to process information slowly
            Thread.Sleep(1500);

            // prompts user for name
            Console.WriteLine("\nWhat is your name?\n");

            // declares that the name of the user is what they will enter
            string userName = Console.ReadLine();

            // while the users name is null or empty, the following occurs - (validation of code)
            while (string.IsNullOrEmpty(userName))
            {
                // informs user to enter a name between 1-25 characters
                Console.WriteLine("Please enter a name between 1-25 letters");
                
                // reads what the user inputted and stores it as a variable by the name "userName"
                userName = Console.ReadLine();
            }

            // while the users name exceeds the 25 character limit, the following occurs - (validation of code)
            while (userName.Length >= 25)
            {
                // informs user to enter a name between 1-25 characters
                Console.WriteLine("Please enter a name between 1-25 letters");

                // reads what the user inputted and stores it as a variable by the name "userName"
                userName = Console.ReadLine();
            }

            // while redo equals true, the following will be conducted
            while (redo == true)
            {
                string levelselection = mainMenu(userName);

                // if a pressed then the following occurs
                if (levelselection == "a")
                {
                    // navigates to CheckAnswers method, passing the name of the user, Beginner Questions, Beginner Answers, and the name of the Level.
                    CheckAnswers(userName, begQuestions, begAnswers, " Beginner");

                }

                // else if b pressed then the following occurs
                else if (levelselection == "b")

                {
                    // navigates to CheckAnswers method, passing the name of the user, Intermediate Questions, Intermediate Answers, and the name of the Level.
                    CheckAnswers(userName, intQuestions, intAnswers, " Intermediate");

                }

                // else if c pressed then the following occurs
                else if (levelselection == "c")

                {
                    // navigates to CheckAnswers method, passing the name of the user, the Advanced Questions, Advanced Answers, and the name of the Level.
                    CheckAnswers(userName, advQuestions, advAnswers, " Advanced");

                }

                //navigates to Redo method while passing the users name
                redo = Redo(userName);

                // end of Main method
            }
        }

        // declares mainMenu method while passing the users name
        static string mainMenu(string userName)
        {
            // clears console visually
            Console.Clear();

            // changes visual colour of text to dark cyan because it is a popular colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // welcomes user using their name to the main menu
            Console.WriteLine("Welcome " + userName + "!");

            // asks user for what level they would like to try - Begginner, Intermediate, or Advanced
            Console.WriteLine("\nWhat level would you like try " + userName + "?\n\na.) Beginner (a)\nb.) Intermediate (b)\nc.) Advanced (c)\n");

            // if the users input includes caps, this will automatically change it to lowercase so the input can be conducted regardless
            string levelselection = Console.ReadLine().ToLower();


            // while any answer besides a, b, or c is pressed then does the following (validates the code) 
            while (!levelselection.Equals("a") && !levelselection.Equals("b") && !levelselection.Equals("c"))
            {
                // changes visual colour of text to yellow because it links to colour theory as if there is something wrong, an error
                Console.ForegroundColor = ConsoleColor.Yellow;

                // informs user to enter a valid level answer
                Console.WriteLine("Please enter valid level - (a, b, or c)");
                
                // reads what user inputted, and stores it as a variable called "levelselection"
                levelselection = Console.ReadLine();

            }
            //returns levelselection
            return levelselection;

            // end of mainMenu method
        }
        // declares CheckAnswers method whilst passing users name, questions array, answers array, and the level they chose
        static void CheckAnswers(string userName, string[] questions, string[] answers, string level)
        {

            // ensures the points reset to 0 if user decides to redo the quiz
            points = 0;

            // clears console visually
            Console.Clear();

            // informs the viewer what level they have chosen
            Console.WriteLine("You have chosen the" + level + " level");

            // begins loop for questions (whatever level the user has selected)
            for (int i = 0; i < questions.Length; i++)
            {
                // changes visual colour of text to dark cyan because it is a popular colour
                Console.ForegroundColor= ConsoleColor.DarkCyan;

                // gives user time to read console info
                Thread.Sleep(2000);

                // clears console visually
                Console.Clear();

                // displays the question from the array
                Console.WriteLine(questions[i] + "\n");

                // reads what the user inputted and stores it as a variable to be able to check if it is correct, also changing the casing to lowercase to ensure the user is correct if answered in caps
                string useranswer = Console.ReadLine().ToLower();

                // while any answer besides a, b, c, or d is pressed then does the following (validates the code) 
                while (!useranswer.Equals("a") && !useranswer.Equals("b") && !useranswer.Equals("c") && !useranswer.Equals("d"))
                {
                    // changes visual colour of text to yellow because it links to colour theory as if there is something wrong, an error
                    Console.ForegroundColor= ConsoleColor.Yellow;

                    // informs user to input a valid answer
                    Console.WriteLine("Please enter valid answer - (a, b, c, or d)");

                    // reads what the user inputted and stores it as a variable to be able to check if it is correct, also changing the casing to lowercase to ensure the user is correct if answered in caps
                     useranswer = Console.ReadLine().ToLower();

                }

                // if answer is correct as per parallel array, the following occurs
                if (useranswer == answers[i])
                {
                    // adds one point to the users total points for the level
                    points++;

                    // changes visual colour of text to green because it links to colour theory, if something is correct or positive it is generally green in colour
                    Console.ForegroundColor= ConsoleColor.Green;
                    
                    // displays that user is correct
                    Console.WriteLine("\nCongratulations! You're correct");

                    // gives user time to read console info
                    Thread.Sleep(1000);
                }

                // else the answer is incorrect as per parallel array, the following occurs
                else
                {
                    // changes visual colour of text to red because it links to colour theory, if something is incorrect or negative it is generally red in colour
                    Console.ForegroundColor= ConsoleColor.Red;

                    // informs the user that they are incorrect
                    Console.WriteLine("\nUnfortunately, you're incorrect, the correct answer was '" + answers[i] +"'\n\nbetter luck next time");


                    // gives user time to read console info
                    Thread.Sleep(1000);
                }

                // displays points for user
                Console.WriteLine("\nYour current score is:" + points + "/" + questions.Length + "");

                // end of CheckAnswers method
            }

        }
        // declares Redo method whilst passing the users name
        static bool Redo(string userName)
        {
            // clears console visually
            Console.Clear();

            // changes visual colour of text to dark cyan because it is a popular colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // informs user of their final score
            Console.WriteLine("Hello " + userName + " your final score was " + points + "/10!\n\n");

            // if the users points are more than 5, the following occurs
            if (points > 5)
            {
                // changes visual colour of text to green because it links to colour theory, if something is correct or positive it is generally green in colour
                Console.ForegroundColor = ConsoleColor.Green;

                // informs user they passed quiz, and that they should try another level
                Console.WriteLine("Good Job " + userName + " you passed the quiz!\n\nHey "+userName+" you should try another level!");

            }

            // if the users points are less than or equal to 5, the following occurs
            else if (points <= 5)
            {
                // changes visual colour of text to red because it links to colour theory, if something is incorrect or negative it is generally red in colour
                Console.ForegroundColor = ConsoleColor.Red;

                // informs user they failed quiz, and that they should retry
                Console.WriteLine("Unlucky " + userName + " you failed the quiz, but you should try again to improve your score!");

            }

            // changes visual colour of text to dark cyan because it is a popular colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // asks user if they would like to redo quiz, gives options - yes, no
            Console.WriteLine("\n\nWould you like to try another level?\n\na.) Yes\nb.) No");

            // reads users input, and stores it as a variable named "redo." if it is answered in caps, it will automatically change it to lowercase so it can be accepted  
            string redo = Console.ReadLine().ToLower();

            // while the users input is null or empty or not "yes" or "no," the user will be informed to type "yes" or "no"
            while (string.IsNullOrEmpty(redo) || (redo != "yes" && redo != "no"))
            {
                // informs the user that they need to enter "yes" or "no," and what that will lead to either the main menu or the end of quiz
                Console.WriteLine("Please type 'yes' to redo or 'no' to leave the quiz.");

                // reads users input, and stores it as a variable named "redo." if it is answered in caps, it will automatically change it to lowercase so it can be accepted  
                redo = Console.ReadLine().ToLower();
            }

            // if users input is no, the following occurs
            if (redo == "no")
            {
                // thanks the user for partaking in the quiz, and tells them to have a great day
                Console.WriteLine("\nThank you " +userName+ ", for playing Vatsal's Te Reo Maori Quiz! Have a great day!");
                
                // return = false
                return false; 
            }
            
            // if users input is yes, the following occurs
            else if (redo == "yes")
            {
                // return = true
                return true; 
            }

            //return = true
            return true;
        }
    }
}