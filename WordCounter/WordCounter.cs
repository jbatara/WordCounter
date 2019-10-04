using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        public RepeatCounter()
        {

        }
        public static List<string> CreateList(string input)
        {
            List<string> outputList = new List<string>();
            return outputList;
        }

        public static List<string> CleanList(List<string> listToClean)
        {
            List<string> cleanedList = new List<string>();
            return cleanedList;
        }

        public static List<string> UniqueValues(List<string> cleanedList)
        {
            List<string> uniqueValues = new List<string>();
            return uniqueValues;
        }

        public static Dictionary<string,int> CountOccurrences(List<string> cleanedList, List<string> uniqueList)
        {
            Dictionary<string,int> occurrances = new Dictionary<string,int>();
            return occurrances;
        }

        public static Dictionary<string,int> WordCount(string input)
        {
            Dictionary<string, int> occurrances = new Dictionary<string, int>();
            return occurrances;
        }
    }
}