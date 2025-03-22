using Microsoft.VisualStudio.TestTools.UnitTesting;
using Implem.Libraries.Utilities;
using System.Text.RegularExpressions;
using System.Linq;

namespace Implem.Libraries.Utilities.Tests
{
    [TestClass]
    public class RegexesTest
    {
        [TestMethod]
        public void TestRegexFirst_MatchFound()
        {
            string input = "Hello World";
            string pattern = "World";
            string result = input.RegexFirst(pattern);
            Assert.AreEqual("World", result);
        }

        [TestMethod]
        public void TestRegexFirst_NoMatch()
        {
            string input = "Hello World";
            string pattern = "Universe";
            string result = input.RegexFirst(pattern);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void TestRegexExists_MatchFound()
        {
            string input = "Hello World";
            string pattern = "World";
            bool result = input.RegexExists(pattern);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestRegexExists_NoMatch()
        {
            string input = "Hello World";
            string pattern = "Universe";
            bool result = input.RegexExists(pattern);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestRegexMatches_MatchFound()
        {
            string input = "Hello World";
            string pattern = "World";
            var matches = input.RegexMatches(pattern);
            Assert.AreEqual(1, matches.Count);
            Assert.AreEqual("World", matches[0].Value);
        }

        [TestMethod]
        public void TestRegexMatches_NoMatch()
        {
            string input = "Hello World";
            string pattern = "Universe";
            var matches = input.RegexMatches(pattern);
            Assert.AreEqual(0, matches.Count);
        }

        [TestMethod]
        public void TestRegexLike_MatchFound()
        {
            string input = "Hello World";
            string pattern = "world";
            var matches = input.RegexLike(pattern);
            Assert.AreEqual(1, matches.Count);
            Assert.AreEqual("World", matches[0].Value);
        }

        [TestMethod]
        public void TestRegexLike_NoMatch()
        {
            string input = "Hello World";
            string pattern = "universe";
            var matches = input.RegexLike(pattern);
            Assert.AreEqual(0, matches.Count);
        }

        [TestMethod]
        public void TestRegexValues_MatchFound()
        {
            string input = "Hello World";
            string pattern = "World";
            var values = input.RegexValues(pattern).ToList();
            Assert.AreEqual(1, values.Count);
            Assert.AreEqual("World", values[0]);
        }

        [TestMethod]
        public void TestRegexValues_NoMatch()
        {
            string input = "Hello World";
            string pattern = "Universe";
            var values = input.RegexValues(pattern).ToList();
            Assert.AreEqual(0, values.Count);
        }
    }
}