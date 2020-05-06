using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfAppSWFFG;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testPool = new DicePool();
            testPool.AddDie(new SuccessTestDie());
            var result = testPool.Roll();
            Assert.AreEqual("1 success ", result);
        }
    }
}
