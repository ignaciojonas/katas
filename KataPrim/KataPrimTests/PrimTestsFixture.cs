using System;
using KataPrim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPrimTests
{
    [TestClass]
    public class PrimTestsFixture
    {
        [TestMethod]
        public void ShouldFindTheMST()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);
            graph.AddLink(1, 2, 10);
            graph.AddLink(1, 3, 20);
            graph.AddLink(2, 4, 10);
            var path = MSTAlgorithms.Prim(graph);
            Assert.AreEqual(path[0], 1);
            Assert.AreEqual(path[1], 2);
            Assert.AreEqual(path[2], 4);
            Assert.AreEqual(path[3], 3);
        }
    }
}
