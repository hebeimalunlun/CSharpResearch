namespace TestCSharpFeatures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        public void TestMethod2()
        {
            Assert.AreEqual(1, 2);
        }
        public void TestMethod3()
        {
            Assert.AreEqual(2, 2);
        }
    }
}