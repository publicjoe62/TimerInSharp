using NUnit.Framework;
using System;
namespace TimerInSharp.UnitTests
{
    [TestFixture()]
    public class ProgramUnitTest : UnitTestsBase
    {
        public ProgramUnitTest()
        {
            cout("construct ProgramUnitTest");
        }

        ~ProgramUnitTest()
        {
            cout("deconstruct ProgramUnitTest");
        }

        [SetUp()]
        public void Setup()
        {
            cout("setup");
        }

        [Test()]
        public void SimpleProgramCall()
        {
            string string2 = "Program call";
            string string1 = "call";
            cout("SimpleProgramCall");
            StringAssert.EndsWith(string1, string2, string.Format("'{0}' in string '{1}' expected!", string2, string1));
        }

        [Test()]
        public void ExtendedProgramCall()
        {
            string stringExpected = "abcde";
            string stringActual = "ABCDE";
            cout("ExtendedProgramCall");
            StringAssert.AreEqualIgnoringCase(stringExpected, stringActual, string.Format("expected string '{0}', but was '{1}'", stringExpected, stringActual));
        }

        [TearDown()]
        public void TearDown()
        {
            cout("teardown");
        }

    }
}
