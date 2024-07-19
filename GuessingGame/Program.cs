using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rdy;
            string theWord;
            char letter;
            



            Console.WriteLine("This is a a basic word guessing game based on a random generated letter.");
            Console.WriteLine("Are you ready?(Yes/No)");
            
            

            rdy = Console.ReadLine();

            if(rdy == "Yes")
            {
                do
                {
                    letter = RandomLetter();
                    Console.WriteLine("Here is your letter>" + letter);
                    
                    theWord = Console.ReadLine();
                    
                    Console.WriteLine("Your word is:" + theWord);
                    char[] word;
                    word = theWord.ToCharArray();
                    if (word[0] == letter)
                    {
                        Console.WriteLine("Well done!");

                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer!");
                    }






                    Console.WriteLine("Do you want to play another round?(Yes/No)");
                    rdy = Console.ReadLine();
                } while (rdy == "Yes");
            }
            
             Console.WriteLine("Bye Bye !");
            
            


            Console.ReadLine();
        }

        static char RandomLetter()
        {
            char[] letter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T','U', 'V', 'W', 'X', 'Y', 'Z' };
            
            int num;
            var rnd = new Random();
            char key;


            num = rnd.Next(0,26);

            

            return letter[num];

            

            

        }
    }
}
