namespace maoriquiz_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Welcome to my Te Reo Maori Quiz!");
            Console.WriteLine("\nWhat is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"What level would you like try "+name+"\n\n1.) Beginner\n2.) Intermediate\n3.) Advanced ?");



        }
    }
}