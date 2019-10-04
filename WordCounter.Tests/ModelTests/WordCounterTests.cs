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
    }
}