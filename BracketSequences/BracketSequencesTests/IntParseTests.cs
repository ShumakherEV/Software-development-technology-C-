using Microsoft.VisualStudio.TestTools.UnitTesting;
using BracketSequences;
using System;
using System.Diagnostics;
using System.IO;

namespace BracketSequencesTests
{
    [TestClass]
    public class IntParseTests
    {
        private static string path = Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "testsOutput.txt");

        [DataTestMethod]
        [DataRow("0", 0)]
        [DataRow("1", 1)]
        [DataRow("1236173", 1236173)]
        [DataRow("2147483647", 2147483647)]
        [DataRow("-2147483648", -2147483648)]
        public void IntParse_StringWithInteger_Integer(string s, int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Arrange
            var expected = n;
            var parse = new Parse();

            // Act
            var actual = parse.IntParse(s);

            
            // Assert
            Assert.AreEqual(expected, actual);

            stopWatch.Stop();

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"IntParse {s} {n}: {stopWatch.Elapsed.TotalMilliseconds}");
            }
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("123w213")]
        [DataRow(null)]
        [DataRow("!@ML:!L$M!")]
        public void IntParse_WrongString_ArgumentException(string s)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Arrange
            var parse = new Parse();

            // Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => parse.IntParse(s));

            Assert.AreEqual("Incorrect input, input must be integer.", ex.Message);

            stopWatch.Stop();

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"IntParse {s}: {stopWatch.Elapsed.TotalMilliseconds}");
            }
        }
    }
}
