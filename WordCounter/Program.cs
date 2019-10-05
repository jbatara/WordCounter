using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Process.Start("/Applications/Google Chrome.app","https://www.google.com");
        }

        public static void MainMenu()
        {
            Console.WriteLine("Welcome to WORDCOUNTER. We are able to calculate the nubmer of occurances for each unique word in your piece of literary art. Please type in the piece of literature that you would like stats for");
            string userInput = Console.ReadLine();
            Dictionary<string,int> wordCount = RepeatCounter.WordCount(userInput);
            string output = PrintDictionary(wordCount);
            Console.WriteLine(output);
            AgainMenu();
            
        }

        public static void AgainMenu()
        {
            Console.WriteLine("Would you like to input another work of art? (y/n)");
            string userInput2 = Console.ReadLine();
            if(userInput2.ToLower()=="y")
            {
                MainMenu();
            }
            else if(userInput2.ToLower() == "n")
            {
                Console.WriteLine("Alright. Bye-bye for now!");
            }
            else
            {
                Console.WriteLine("I'm sorry. That is not a valid response. Please try again.");
                AgainMenu();
            }
        }

        public static string PrintDictionary(Dictionary<string,int> quantDict)
        {
            string output = "";
            foreach(string key in quantDict.Keys)
            {
                if(quantDict[key] ==1)
                {
                    output+="\nThe word '"+ key + "' appears " + quantDict[key] + " time.";
                }
                else
                {
                    output+="\nThe word '"+ key + "' appears " + quantDict[key] + " times.";
                }
            }
            return output;
        }

        
    }
}