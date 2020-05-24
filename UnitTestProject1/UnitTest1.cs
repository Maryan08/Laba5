using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float spv = 1;
            int result = OOP_Lab_5._2.Work.Number(spv);
            Assert.AreEqual(1, result);

        }
    }
}
