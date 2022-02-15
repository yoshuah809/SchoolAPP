using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testIntance = new Class1();
            var testResults = testIntance.AddTwo(5,500);
            Assert.AreEqual(505, testResults, "I expect 5 + 500 to be 505");
        }
        public void TestMethod2()
        {
            var testInstance2 = new SimpleArray();
            Assert.Equals(testInstance2.gList.Length, 4);
        }
    }
}
