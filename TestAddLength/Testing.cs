using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace TestAddLength
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void AddString_PositiveAddition_CheckString()
        {
            //Arrage
            CList<string> list = new CList<string> { };
            string newString = "New Addition";
            //Act
            list.Add(newString);
            //Assert
            Assert.AreEqual(list[0], newString);
        }
        [TestMethod]
        public void AddInt_PositiveAddition_CheckInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int newInt = 1;
            //Act
            list.Add(newInt);
            //Assert
            Assert.AreEqual(list[0], newInt);
        }
        [TestMethod]
        public void AddStrings_PositiveAddition_CheckSecondString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            //Act
            list.Add(new1String);
            list.Add(new2String);
            //Assert
            Assert.AreEqual(list[1], new2String);
        }
        [TestMethod]
        public void AddInts_PositiveAddition_CheckSecondInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            //Act
            list.Add(new1Int);
            list.Add(new2Int);
            //Assert
            Assert.AreEqual(list[1], new2Int);
        }
        [TestMethod]
        public void AddThreeStrings_PositiveAddition_CheckThirdString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            //Act
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //Assert
            Assert.AreEqual(list[2], new3String);
        }
        [TestMethod]
        public void AddThreeInts_PositiveAddition_CheckThirdInt()
        {
            //Arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            //Act
            list.Add(new1Int);
            list.Add(new2Int);
            list.Add(new3Int);
            //Assert
            Assert.AreEqual(list[2], new3Int);
        }
        [TestMethod]
        public void AddStrings_CheckCount_CorrectCount()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            //Act
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //Assert
            Assert.AreEqual(list.Count, 3);
        }
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
        [TestMethod]
        public void CheckIEnumerableCount_PositiveTest_SameString()
        {
            //Arrange
            CList<string> list = new CList<string> { };
            int counter = 0;
            string new1String = "New Addition 1";
            string new2String = "New Addition 2";
            string new3String = "New Addition 3";
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //Act
            foreach (var item in list)
            {
                counter++;
            }
            //Assert
            Assert.AreEqual(counter, 3);
        }
        [TestMethod]
        public void ConvertToSTring_PositiveTest_StringVersion()
        {
            //arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            list.Add(new1Int);
            //act
            string testString = list.ToString();
            //assert
            Assert.AreEqual("1", testString);
        }
        [TestMethod]
        public void Convert3ToSTring_PositiveTest_StringVersion()
        {
            //arrange
            CList<int> list = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            list.Add(new1Int);
            list.Add(new2Int);
            list.Add(new3Int);
            //act
            string testString = list.ToString();
            //assert
            Assert.AreEqual("123", testString);
        }
        [TestMethod]
        public void ConvertStringsToSTring_PositiveTest_StringVersion()
        {
            //arrange
            CList<string> list = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            string new3String = "3";
            list.Add(new1String);
            list.Add(new2String);
            list.Add(new3String);
            //act
            string testString = list.ToString();
            //assert
            Assert.AreEqual("123", testString);
        }
        [TestMethod]
        public void Combine2Lists_PositiveTest_String1Fr()
        {
            //arrange
            CList<string> list1 = new CList<string> { };
            CList<string> list2 = new CList<string> { };
            CList<string> list3 = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            list1.Add(new1String);
            list2.Add(new2String);
            //act
            list3.Join(list1, list2);
            //assert
            Assert.AreEqual(list3[0], "1");
        }
        [TestMethod]
        public void Combine2Lists_PositiveTest_NewCombinedList()
        {
            //arrange
            CList<string> list1 = new CList<string> { };
            CList<string> list2 = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            list1.Add(new1String);
            list2.Add(new2String);
            //act
            CList<string> list3 = list1 + list2;
            //assert
            Assert.AreEqual(list3[1], "2");
        }
        [TestMethod]
        public void Combine2Lists_PositiveTest_OriginalList()
        {
            //arrange
            CList<string> list1 = new CList<string> { };
            CList<string> list2 = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            list1.Add(new1String);
            list2.Add(new2String);
            //act
            CList<string> list3 = list1 + list2;
            //assert
            Assert.AreEqual(list1.Count, 1);
        }
        [TestMethod]
        public void Combine2ListsString_PositiveTest_CheckNewListCount()
        {
            //arrange
            CList<string> list1 = new CList<string> { };
            CList<string> list2 = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            list1.Add(new1String);
            list2.Add(new2String);
            //act
            CList<string> list3 = list1 + list2;
            //assert
            Assert.AreEqual(list3.Count, 2);
        }
        [TestMethod]
        public void Combine2ListsInt_PositiveTest_CheckNewListCount()
        {
            //arrange
            CList<int> list1 = new CList<int> { };
            CList<int> list2 = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            list1.Add(new1Int);
            list2.Add(new2Int);
            //act
            CList<int> list3 = list1 + list2;
            //assert
            Assert.AreEqual(list3.Count, 2);
        }
        [TestMethod]
        public void Reduce2Lists_PositiveTest_Same1List()
        {
            //arrange
            CList<int> list1 = new CList<int> { };
            CList<int> list2 = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            int new4Int = 4;
            int new5Int = 5;
            int new6Int = 6;
            list1.Add(new1Int);
            list1.Add(new2Int);
            list1.Add(new3Int);
            list2.Add(new4Int);
            list2.Add(new5Int);
            list2.Add(new6Int);
            //act
            string test1String = list1.ToString();
            string test2String = list2.ToString();
            CList<int> list3 = list1 - list2;
            string test3String = list3.ToString();
            //assert
            Assert.AreEqual(test3String, test1String);
        }
        [TestMethod]
        public void Reduce2ListsWIthInt_PositiveTest_Different1List()
        {
            //arrange
            CList<string> list1 = new CList<string> { };
            CList<string> list2 = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            string new3String = "3";
            string new4String = "4";
            string new5String = "5";
            string new6String = "6";
            list1.Add(new1String);
            list1.Add(new2String);
            list1.Add(new3String);
            list2.Add(new4String);
            list2.Add(new5String);
            list2.Add(new6String);
            //act
            string test1Int = list1.ToString();
            string test2Int = list2.ToString();
            CList<string> list3 = list1 - list2;
            string test3Int = list3.ToString();
            //assert
            Assert.AreEqual(test3Int, test1Int);
        }
        [TestMethod]
        public void Zip2Lines_PositiveZip_CorrectStringOrder()
        {
            //arrange   
            CList<string> list1 = new CList<string> { };
            CList<string> list2 = new CList<string> { };
            string new1String = "1";
            string new2String = "2";
            string new3String = "3";
            string new4String = "4";
            string new5String = "5";
            string new6String = "6";
            list1.Add(new1String);
            list1.Add(new2String);
            list1.Add(new3String);
            list2.Add(new4String);
            list2.Add(new5String);
            list2.Add(new6String);
            //act
            CList<string> list3 = list1.Zip(list2);
            string testString = list3.ToString();
            //assert
            Assert.AreEqual("142536", testString);
        }
        [TestMethod]
        public void Zip2Lines_PositiveZip_CorrectIntOrder()
        {
            //arrange   
            CList<int> list1 = new CList<int> { };
            CList<int> list2 = new CList<int> { };
            int new1Int  = 1;
            int new2Int = 2;
            int new3Int = 3;
            int new4Int = 4;
            int new5Int = 5;
            int new6Int = 6;
            list1.Add(new1Int);
            list1.Add(new2Int);
            list1.Add(new3Int);
            list2.Add(new4Int);
            list2.Add(new5Int);
            list2.Add(new6Int);
            //act
            CList<int> list3 = list1.Zip(list2);
            string testString = list3.ToString();
            //assert
            Assert.AreEqual("142536", testString);
        }
        [TestMethod]
        public void Zip2Lines_PositiveZip_CorrectCount()
        {
            //arrange   
            CList<int> list1 = new CList<int> { };
            CList<int> list2 = new CList<int> { };
            int new1Int = 1;
            int new2Int = 2;
            int new3Int = 3;
            int new4Int = 4;
            int new5Int = 5;
            int new6Int = 6;
            list1.Add(new1Int);
            list1.Add(new2Int);
            list1.Add(new3Int);
            list2.Add(new4Int);
            list2.Add(new5Int);
            list2.Add(new6Int);
            //act
            CList<int> list3 = list1.Zip(list2);
            string testString = list3.ToString();
            //assert
            Assert.AreEqual(list3.Count, 6);
        }
    }
}
