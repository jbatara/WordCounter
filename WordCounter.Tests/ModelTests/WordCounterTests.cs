using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace WordCounter.Testing
{
    [TestClass]
    public class WordCounterTets
    {
        [TestMethod]
        public void CreateList_CheckIfOutputIsListofWords_ListofWords()
        {
            string userInput = "This is an example of a valid input. \n It even takes things like extra character$.";

            string[] expected =  new string[] {"This", "is", "an","example","of","a","valid","input.", "It", "even", "takes", "things", "like", "extra", "character$."};
            string[] actual = RepeatCounter.CreateList(userInput);

            CollectionAssert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CleanList_CheckIfOutputIsListofWords_ListofWords()
        {
            string[]listofWords = new string[] {"This", "is", "an","example","of","a","valid","input.", "It", "even", "takes", "things", "like", "extra", "character$."};

            List<string> expected =  new List<string>(){"this", "is", "an","example","of","a","valid","input", "it", "even", "takes", "things", "like", "extra", "character$"};
           List<string> actual = RepeatCounter.CleanList(listofWords);

            CollectionAssert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void UniqueValues_CheckIfOutputIsAllUniqueWords_UniqueStringList()
        {
            List<string> cleanedWords = new List<string>() {"this", "is", "an","example","of","a","valid","input", "it", "even", "will", "take", "a", "few","things", "like", "extra", "character$"};

            List<string> expected =  new List<string>() {"this", "is", "an","example","of","a","valid","input", "it", "even","will", "take","few", "things", "like", "extra", "character$"};
            List<string> actual = RepeatCounter.UniqueValues(cleanedWords);

            CollectionAssert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CountOccurances_CheckIfOutputIsDictionary_DictionaryStringInt()
        {
            string userInput = "This is an example of a valid input. \n It even takes things like extra character$ if you want it to of course.";
            List<string> cleanedWords = RepeatCounter.CleanList(RepeatCounter.CreateList(userInput));
            List<string> uniqueWords = RepeatCounter.UniqueValues(cleanedWords);

            Dictionary<string,int> expectedDict =  new Dictionary<string,int>(){{"this", 1},{"is",1},{"an", 1},{"example",1},{"of",2},{"a",1},{"valid",1},{"input",1},{"it",2},{"even",1},{"takes",1},{"things",1},{"like", 1},{"extra",1},{"character$",1},{"if",1},{"you",1},{"want",1},{"to",1},{"course",1}};
            List<int> expected = new List<int>();
            foreach(string key in expectedDict.Keys)
            {
                expected.Add(expectedDict[key]);
            }
            Dictionary<string,int> actualDict = RepeatCounter.CountOccurrences(cleanedWords, uniqueWords);
            List<int> actual = new List<int>();
            foreach(string key in actualDict.Keys)
            {
                actual.Add(actualDict[key]);
            }

            CollectionAssert.AreEqual(expected,actual);
        }

          [TestMethod]
        public void WordCount_CheckIfOutputIsString_String()
        {
           string userInput = "This is an examples of a valid input. \n It even takes things like extra character$.";

            Dictionary<string,int> expected =  new Dictionary<string,int>(){{"this", 1},{"is",1},{"an", 1},{"example",1},{"of",1},{"a",1},{"valid",1},{"input",1},{"it",1},{"even",1},{"takes",1},{"things",1},{"like", 1},{"extra",1},{"character$",1}};
            Dictionary<string,int> actual = RepeatCounter.WordCount(userInput);

            CollectionAssert.AreEqual(expected,actual);
        }
    }
}