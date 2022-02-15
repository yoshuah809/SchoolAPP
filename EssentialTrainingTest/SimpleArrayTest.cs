using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;


namespace EssentialTrainingTest
{
    [TestClass]     
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
          var testInstance2 = new SimpleArray();
          Assert.AreEqual(testInstance2.gList.Length, 4);
       
        }
    }
}
