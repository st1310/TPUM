using NUnit.Framework;

namespace TPUM_2021.Test
{
    public class Tests
    {
        private static object[] _testNewProjectStaticMethodTestSource =
        {
            new TestCaseData("TestMe").SetName("TestNewProjectStaticMethod_NoInput_TestMeStringReturned")
        };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(nameof(_testNewProjectStaticMethodTestSource))]
        public void Test1(string expectedResult)
        {
            string result = Program.TestMe();

            Assert.AreEqual(expectedResult, result);
        }
    }
}