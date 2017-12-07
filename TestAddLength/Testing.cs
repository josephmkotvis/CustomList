using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace TestAddLength
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void Add_String_Check_String()
        {
            CList<string> list = new CList<string> { };
            string newString = "New Addition";
            list.Add(newString);
            Assert.AreEqual(list[0], newString);
        }
        [TestMethod]
        public void Add_Int_Check_Int()
        {
            CList<int> list = new CList<int> { };
            int newInt = 1;
            list.Add(newInt);
            Assert.AreEqual(list[0], newInt);
        }
        [TestMethod]
        public void Add_Strings_Check_Second_String()
        {
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            list.Add(new1String);
            list.Add(new2String);
            Assert.AreEqual(list[1], new2String);
        }
        [TestMethod]
        public void Add_Ints_Check_Second_Int()
        {
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            list.Add(new1Int);
            list.Add(new2Int);
            Assert.AreEqual(list[1], new2Int);
        }
        [TestMethod]
        public void Add_Three_Strings_Check_Third_String()
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
        public void Add_Three_Ints_Check_Third_Int()
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
        //public void TestStringReplacement()
        //{
        //    CList<string> list = new CList<string> { };
        //string new1String = "New Addition 1";
        //    string new2String = "New Addition 2";
        //    string new3String = "New Addition 3";
        //    list.Add(new1String);
        //    list.Add(new2String);
        //    list.Add(new3String);
        //    int indexReplaced = 3;
        //    string newStringReplacing = "Replacement";
        //    list.ReplaceOnList(newStringReplacing, indexReplaced);
        //    Assert.AreEqual(list[indexReplaced], newStringReplacing);
        //}
        [TestMethod]
        public void RemoveString_PositiveRemoval_NextString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            list.Add(new1String);
            list.Add(new2String);
            //Act
            list.Remove(new1String);
            //Assert
            Assert.AreEqual(list[0], new2String);
        }
        [TestMethod]
        public void RemoveString_NegativeRemoval_NextString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            list.Add(new1String);
            list.Add(new2String);
            //Act
            list.Remove(new1String);
            //Assert
            Assert.AreNotEqual(list[0], new1String);
        }
        [TestMethod]
        public void RemoveStringFrom3_PositiveRemoval_NextString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //Act
            list.Remove(new2String);
            //Assert
            Assert.AreEqual(list[1], new3String);
        }
        [TestMethod]
        public void RemoveStringFrom3_NegativeRemoval_NextString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //Act
            list.Remove(new2String);
            //Assert
            Assert.AreNotEqual(list[1], new2String);
        }
        [TestMethod]
        public void RemoveInt_PositiveRemoval_NextInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            list.Add(new1Int);
            list.Add(new2Int);
            //Act
            list.Remove(new1Int);
            //Assert
            Assert.AreEqual(list[0], new2Int);
        }
        [TestMethod]
        public void RemoveInt_NegativeRemoval_NextInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            list.Add(new1Int);
            list.Add(new2Int);
            //Act
            list.Remove(new1Int);
            //Assert
            Assert.AreNotEqual(list[0], new1Int);
        }
        [TestMethod]
        public void RemoveIntFrom3_PositiveRemoval_NextInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            list.Add(new1Int);
            list.Add(new2Int);
            list.Add(new3Int);
            //Act
            list.Remove(new2Int);
            //Assert
            Assert.AreEqual(list[1], new3Int);
        }
        [TestMethod]
        public void RemoveIntFrom3_NegativeRemoval_NextInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            list.Add(new1Int);
            list.Add(new2Int);
            list.Add(new3Int);
            //Act
            list.Remove(new2Int);
            //Assert
            Assert.AreNotEqual(list[1], new2Int);
        }
        [TestMethod]
        public void RemoveStringFrom3_PositiveRemoval_CorrectCount()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //Act
            list.Remove(new2String);
            //Assert
            Assert.AreEqual(list.Count, 2);
        }
        [TestMethod]
        public void RemoveFalseStringFrom2_PositiveRemoval_CorrectCount()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            //Act
            list.Remove(new3String);
            //Assert
            Assert.AreEqual(list.Count, 2);
        }
        [TestMethod]
        public void RemoveFalseStringFrom2_PositiveRemoval_SameString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            //Act
            list.Remove(new3String);
            //Assert
            Assert.AreEqual(list[1], new2String);
        }
        [TestMethod]
        public void RemoveFalseIntFrom2_PositiveRemoval_SameInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            list.Add(new1Int);
            list.Add(new2Int);
            //Act
            list.Remove(new3Int);
            //Assert
            Assert.AreEqual(list[1], new2Int);
        }
    }
}
