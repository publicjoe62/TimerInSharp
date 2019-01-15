using NUnit.Framework;
using System;
namespace TimerInSharp.UnitTests
{
    [TestFixture()]
    public class Delegates1UnitTest : UnitTestsBase
    {

        public Delegates1UnitTest()
        {
            cout("Delegates1UnitTest::Constructor");
        }

        [SetUp()]
        public void Setup()
        {
            cout("Delegates1UnitTest::Setup");
        }

        [TearDown()]
        public void TearDown()
        {
            cout("Delegates1UnitTest::TearDown");
        }

        [Test()]
        public void Sample1()
        {
            cout("Delegates1UnitTest::Testcase Sample1");
            new Delegates1().sample1();
            Assert.Pass("Delegates1UnitTest::Testcase Sample1 passed");
        }

    }
}
