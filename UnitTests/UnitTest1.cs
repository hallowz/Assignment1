using A1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace A1UnitTests
{
    [TestClass]
    public class SubsequenceFinderTester
    {
        [TestMethod]
        public void InvalidSubsequence()
        {
            List<int> seq = new List<int> { 3, 4, 3, 2, 3, 7, 8, 9, 4, 3, 2 };
            List<int> subseq = new List<int> { 3, 2, 3, 7, 3 };
            bool isSubSeq = SubsequenceFinder.IsValidSubsequeuce(seq, subseq);
            Assert.IsFalse(isSubSeq);
        }
        [TestMethod]
        public void ValidSubsequence()
        {
            List<int> seq = new List<int> { 3, 4, 3, 2, 3, 7, 8, 9, 4, 3, 2 };
            List<int> subseq = new List<int> { 3, 2, 3, 7, 8 };
            bool isSubSeq = SubsequenceFinder.IsValidSubsequeuce(seq, subseq);
            Assert.IsTrue(isSubSeq);
        }
    }
}
