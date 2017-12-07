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
            CList<string> list = new CList<string>{};
            string newString = "New Addition";
            list.Add(newString);
            Assert.AreEqual(list[0], newString);
        }
        [TestMethod]
        public void TestAdditionOfInt()
        {
            CList<int> list = new CList<int> { };
            int newInt = 1;
            list.Add(newInt);
            Assert.AreEqual(list[0], newInt);
        }
        [TestMethod]
        public void TestAdditionOf2Strings()
        {
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            list.Add(new1String);
            list.Add(new2String);
            Assert.AreEqual(list[1], new2String);
        }
        [TestMethod]
        public void TestAdditionOf2Int()
        {
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            list.Add(new1Int);
            list.Add(new2Int);
            Assert.AreEqual(list[1], new2Int);
        }
        [TestMethod]
        public void TestAdditionOf3Strings()
        {
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            Assert.AreEqual(list[2], new3String);
        }
        [TestMethod]
        public void TestAdditionOf3Int()
        {
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            list.Add(new1Int);
            list.Add(new2Int);
            list.Add(new3Int);
            Assert.AreEqual(list[2], new3Int);
        }
        //public void TestStringReplactement()
        //{
        //    Program program = new Program();    
        //    int indexReplaced = 3;
        //    string newString = "Replacement";
        //    string newReplacedString = program.ReplaceOnList(newString, indexReplaced);
        //    Assert.AreEqual(newReplacedString, newString[indexReplaced]);
        //}
        //public void TestStringRemoval()
        //{
        //    Program program = new Program();
        //    int indexRemoved = 6;
        //    string removedString = "Removed";
        //    string nextString = "Next";
        //    string newStringAtLocation = program.RemoveFromList(removedString[indexRemoved]);
        //    Assert.AreEqual(newStringAtLocation, nextString [indexRemoved]);
        //}

    }
}
