/*
Author: Deegan Acevedo
Course: COMP-003A
Faculty: Jonathan Cruz
Purpose: Application will greet the user after inputting their name and display some info about me
*/
namespace COMP003A.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //Greet user
            Console.WriteLine("Hello, " + name + "! My name is Deegan Acevedo.");

            //List of 10 things about me
            Console.WriteLine("\n\n1. Here are 10 things about me:\n\t" +
                            "1. I graduated from high school last school year at Hanford West High School.\n\t" +
                            "2. I just went to Lemoore College this semester.\n\t" +
                            "3. I enjoy riding bicycles every now and then.\n\t" +
                            "4. I enjoy most music other than country and k-pop.\n\t" +
                            "5. I enjoy playing videogames of almost any genre.\n\t" +
                            "6. I have had my driving permit for well over a year, but still haven't driven much.\n\t" +
                            "7. I like meat more than most other foods.\n\t" +
                            "8. I have had an interest in coding for a while but never got into it.\n\t" +
                            "9. I don't care that much about social media and don't use it that seriously.\n\t" +
                            "10. I don't like cake that much unless it's chococlate, it's too sweet.");
            
        }
    }
}
