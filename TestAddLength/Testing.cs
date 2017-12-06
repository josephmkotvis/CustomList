using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace TestAddLength
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestAdditionOfString()
        {
            CList<string> list = new CList<string>();
            // CList<string> list = new CList<string>();
            int arrayLength = 3;
            string newString = "New Addition";
            string AddedString = program.Add(newString);
            Assert.AreEqual(AddedString, newString[arrayLength]);
        }



        public void TestStringReplactement()
        {
            Program program = new Program();
            int indexReplaced = 3;
            string newString = "Replacement";
            string newReplacedString = program.ReplaceOnList(newString, indexReplaced);
            Assert.AreEqual(newReplacedString, newString[indexReplaced]);
        }
        public void TestStringRemoval()
        {
            Program program = new Program();
            int indexRemoved = 6;
            string removedString = "Removed";
            string nextString = "Next";
            string newStringAtLocation = program.RemoveFromList(removedString[indexRemoved]);
            Assert.AreEqual(newStringAtLocation, nextString [indexRemoved]);
        }

    }
}
