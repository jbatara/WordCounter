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
            string userInput = "This is an examples of a valid input. \n It even takes things like extra character$.";

            List<string> expected =  new List<string>() {"This", "is", "an","example","of","a","valid","input.", "It", "even", "takes", "things", "like", "extra", "character$."};
            List<string> actual = RepeatCounter.CreateList(userInput);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CleanList_CheckIfOutputIsListofWords_ListofWords()
        {
            List<string> listofWords = new List<string>() {"This", "is", "an","example","of","a","valid","input.", "It", "even", "takes", "things", "like", "extra", "character$."};

            List<string> expected =  new List<string>() {"this", "is", "an","example","of","a","valid","input", "it", "even", "takes", "things", "like", "extra", "character$"};
            List<string> actual = RepeatCounter.CleanList(listofWords);

            Assert.AreEqual(expected,actual);
        }
    }
}