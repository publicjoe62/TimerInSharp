using NUnit.Framework;
using System;
namespace TimerInSharp.UnitTests
{
    [TestFixture()]
    public class FeedCheckUnitTest : UnitTestsBase
    {
        [SetUp()]
        public void Setup()
        {
            cout("setup");
        }

        [Test()]
        public void SmokeTest()
        {
            cout("SmokeTest");
        }

        [TearDown()]
        public void TearDown()
        {
            cout("teardown");
        }
    }
}
