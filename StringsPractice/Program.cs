using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            string firstName = "Iris";
                        int lengthOfName = firstName.Length;
                        Console.WriteLine(lengthOfName);

                        Console.WriteLine("Please enter your first name");
                        string firsttName = Console.ReadLine();
                        int lengtthOfName = firstName.Length;
                        Console.WriteLine("The length of your first name is:" + lengthOfName);
                        //escape character treats as a string, not as an operator

                        string myFaveQuote = "\" It's a yam sham\"-Buffy Summers";
                        Console.WriteLine(myFaveQuote);

                        string escapeString = "I want a tab after this line \t I want a new line without a WriteLine\n Hiya!";
                        string escapeString2 = "I want to show a backslash here \\ Hey what's that noise\a";
                        Console.WriteLine(escapeString);
                        Console.WriteLine(escapeString2);

                        Console.WriteLine("User one, please type something");
                        string userOneInput = Console.ReadLine();
                        Console.WriteLine("User two, please type something");
                        string userTwoInput = Console.ReadLine();
                        bool isMatch = true;
                        if (userOneInput == userTwoInput) //(userOneInput.Equals(userTwoInput)) //user 1 input is not our class, but our object and we are able to call a method on it...why how?

                        {
                            Console.WriteLine("User 2 is a copy cat!");
                        }
                        else
                        {
                            Console.WriteLine("Way to be original!");
                        }
                        //Practice with concatenating
                        //There is a .concat method but it wasn't working for Daniel in class//NVM we got it
                        string startOfSentence = "My best friend's name is ";
                        string endOfSentence = "Bethany.";
                        string fullsentence = startOfSentence + endOfSentence + "\n";
                        Console.WriteLine(fullsentence);
                        Console.WriteLine(startOfSentence);
                        Console.WriteLine(endOfSentence);

                        fullsentence = string.Concat(startOfSentence, endOfSentence);
                        Console.WriteLine("My best friend's name is " + "Bethany.");

                        Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");// This is nice
                        Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);//This is nicer
                        Console.WriteLine("The first part of my sentence was {0}, the second was {1}, and the third was {2}", startOfSentence, endOfSentence, fullsentence);
            */
            //  Console.WriteLine("This is a tab. \t \nThis is a backspace\\. \nThis is a bell sound\a.");

            //string firstName = "Iris";
            //int lengthOf1stName = firstName.Length;
            //Console.WriteLine(lengthOf1stName);

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            int lengthOfFirstName = firstName.Length;

            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            int lengthOfLastName = lastName.Length;
            Console.WriteLine(lengthOfLastName);

            if (lengthOfFirstName >lengthOfLastName)
            {
                Console.WriteLine("First is longer!\a");
            }
            else if (lengthOfFirstName == lengthOfLastName)
            {
                Console.WriteLine("Samsis!\a");
            }
            else
            {
                Console.WriteLine("last must be longer!\a");
            }

            Console.WriteLine("What is your first name");
            string myUserFirstName = Console.ReadLine();

            Console.WriteLine("What is your last name");
            string myUserLastName = Console.ReadLine();

            string myUsersFullName = myUserFirstName + myUserLastName;




        }
    }
}
