using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class RepeatCounter
    {
        public RepeatCounter()
        {

        }
        public static string[] CreateList(string input)
        {
            char[] spacesAndNewLine = new char[]{'\n',' '};
            string[] separatedWords = input.Split(spacesAndNewLine, StringSplitOptions.RemoveEmptyEntries);
            return separatedWords;
        }

        public static List<string> CleanList(string[] listToClean)
        {
            List<string> cleanedList = new List<string>();
            for(int i = 0; i<listToClean.Length;i++)
            {
                string currentWord = listToClean[i];
                int currentWordLength = currentWord.Length;
                string lastLetter = currentWord[currentWordLength-1].ToString();
                string[] punctuationToOmit = new string[] {".", ",", "?"};
                if(punctuationToOmit.Contains(lastLetter))
                {
                    string noPunctuationWord = currentWord.Substring(0,currentWordLength-1);
                    cleanedList.Add(noPunctuationWord.ToLower());
                }
                else
                {
                    cleanedList.Add(currentWord.ToLower());
                }
            }

            return cleanedList;
        }

        public static List<string> UniqueValues(List<string> cleanedList)
        {
            List<string> unique = new List<string>();
            for(int i = 0; i <cleanedList.Count;i++)
            {
                string currentWord = cleanedList[i];
                if(!(unique.Contains(currentWord)))
                {
                    unique.Add(currentWord);
                }
            }
            return unique;
        }

        public static Dictionary<string,int> CountOccurrences(List<string> cleanedList, List<string> uniqueList)
        {
            Dictionary<string,int> occurrances = new Dictionary<string,int>();
            foreach(string key in uniqueList)
            {
                occurrances[key] = 0;
            }
            foreach(string word in cleanedList)
            {
                occurrances[word]+=1;
            }
            return occurrances;
        }

        public static Dictionary<string,int> WordCount(string input)
        {
            string[] list = CreateList(input);
            List<string> cleanList = CleanList(list);
            List<string> uniqueList = UniqueValues(cleanList);
            Dictionary<string, int> occurrances = CountOccurrences(cleanList, uniqueList);
            return occurrances;
        }
    }
}