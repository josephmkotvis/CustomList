using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAddLength
{
    [TestClass]
    public class TestAddToLength
    {
        [TestMethod]
        public void Add1toLength()    
        {
            Program program = new Program();
            int currentListLength = 0;
            int result = program.addListLength(currentListLength);
            Assert.AreEqual(result, 1); 
        }

    }
}
