using Microsoft.VisualStudio.TestTools.UnitTesting;
using BracketSequences;
using System.Collections.Generic;
using System;
using System.IO;
using System.Diagnostics;

namespace BracketSequencesTests
{
    [TestClass]
    public class BracketSequencesTests
    {
        private static string path = Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "testsOutput.txt");

        [TestMethod]
        public void GetBracketSequences_1_OneSequence()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Arrange
            var reporter = new ReporterList();
            int n = 1;
            List<string> expected = new List<string> { "()" };
            BracketSequence bracketSequences = new BracketSequence() { Reporter = reporter};

            // Act
            bracketSequences.GetBracketSequences(n);

            // Assert
            var actual = reporter.list;
            CollectionAssert.AreEqual(expected, actual);

            stopWatch.Stop();

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"GetBracketSequences 1: {stopWatch.Elapsed.TotalMilliseconds}");
            }
        }

        [TestMethod]
        public void GetBracketSequences_3_FiveSequences()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Arrange
            var reporter = new ReporterList();
            int n = 3;
            List<string> expected = new List<string>
            {
                "((()))",
                "(()())",
                "(())()",
                "()(())",
                "()()()",
            };
            BracketSequence bracketSequences = new BracketSequence() { Reporter = reporter };

            // Act
            bracketSequences.GetBracketSequences(n);

            // Assert
            var actual = reporter.list;
            CollectionAssert.AreEquivalent(expected, actual);

            stopWatch.Stop();

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"GetBracketSequences 3: {stopWatch.Elapsed.TotalMilliseconds}");
            }
        }


        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-100)]
        [DataRow(0)]
        public void GetBracketSequences_NegativeNumbersOrZero_ArgumentException(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Arrange
            BracketSequence bracketSequences = new BracketSequence();

            // Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => bracketSequences.GetBracketSequences(n));

            Assert.AreEqual("Incorrect input, integer must be positive.", ex.Message);

            stopWatch.Stop();

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"GetBracketSequences {n}: {stopWatch.Elapsed.TotalMilliseconds}");
            }
        }
    }
}
