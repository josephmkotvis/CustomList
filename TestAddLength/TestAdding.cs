using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace TestAddLength
{
    [TestClass]
    public class TestAdding
    {
        [TestMethod]
        public void TestAdditionOfString()
        {
            Program program = new Program();
            int pastArrayLength = 3;
            string newString = "New Addition";
            string AddedString = program.AddToList(newString);
            Assert.AreEqual(AddedString, newString[pastArrayLength]);
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
