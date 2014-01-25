using System;
using System.Collections.Generic;
using KataPrim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPrimTests
{
    [TestClass]
    public class GraphTestsFixture
    {
        [TestMethod]
        public void ShouldAddNode()
        {
            var graph = new Graph();
            graph.AddNode(1);
            Assert.IsTrue(graph.ContainNode(1));
        }

        [TestMethod]
        public void ShouldRemoveNode()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.RemoveNode(1);
            Assert.IsFalse(graph.ContainNode(1));
        }

        [TestMethod]
        public void ShouldRemoveAllTheLinksRelatedWhenRemoveANode()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddLink(1, 2, 50);
            graph.AddLink(2, 1, 20);
            graph.RemoveNode(1);
            Assert.AreEqual(graph.GetLink(1,2), 0);
        }


        [TestMethod]
        public void ShouldAddLink()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddLink(1, 2, 50);
            Assert.AreEqual(graph.GetLink(1,2),50);
        }

        [TestMethod]
        public void ShouldNotAddAnExistingLink()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddLink(1, 2, 50);
            Assert.IsFalse(graph.AddLink(1, 2, 50));
        }



        [TestMethod]
        public void ShouldRemoveALink()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddLink(1, 2, 50);
            Assert.IsTrue(graph.RemoveLink(1, 2));
            Assert.AreEqual(graph.GetLink(1, 2), 0);
        }

        [TestMethod]
        public void ShouldReturnFalseWhenTryToRemoveAnUnexistingLink()
        {
            var graph = new Graph();
            Assert.IsFalse(graph.RemoveLink(1, 2));
        }

        [TestMethod]
        public void ShouldRemoveAllLinks()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddLink(1, 2, 50);
            graph.AddLink(2, 1, 50);
            graph.RemoveAllLinks(1);
            Assert.AreEqual(graph.GetLink(1, 2), 0);
            Assert.AreEqual(graph.GetLink(2, 1), 0);
        }

        [TestMethod]
        public void ShouldNotAddLinkWithWeightZero()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            Assert.IsFalse(graph.AddLink(1, 2, 0));
        }

        [TestMethod]
        public void ShouldGetAmountOfNodes()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            Assert.AreEqual(graph.NodesCount(),2);
        }

        [TestMethod]
        public void ShouldGetNeighboursOrderedByWeight()
        {
            var graph = new Graph();
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);
            graph.AddNode(4);
            graph.AddLink(1, 2, 50);
            graph.AddLink(1, 3, 20);
            graph.AddLink(2, 4, 30);
            List<Link> neighbours = graph.GetNeighbours(1);
            Assert.AreEqual(neighbours.Count,2);
            Assert.AreEqual(neighbours[0].w, 20);
            Assert.AreEqual(neighbours[1].w, 50);
        }
    }
}
