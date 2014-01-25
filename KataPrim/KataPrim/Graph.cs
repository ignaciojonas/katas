using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPrim
{
    public class Graph
    {
        List<int> nodes;
        List<Link> links;
        
        public Graph()
        {
            this.nodes = new List<int>();
            this.links = new List<Link>();
        }

        public void AddNode(int node)
        {
            nodes.Add(node);
        }

        public bool ContainNode(int node)
        {
            return nodes.Contains(node);
        }

        public int NodesCount()
        {
            return nodes.Count;
        }

        public bool AddLink(int n1, int n2, int w)
        {
            if (w != 0)
            {
                if (!this.links.Exists(link => link.n1 == n1 & link.n2 == n2))
                {
                    this.links.Add(new Link(n1, n2, w));
                    this.links.Add(new Link(n2, n1, w));
                    return true;
                }
            }
            
            return false;
        }

        public int GetLink(int n1, int n2)
        {
            var rlink = links.Find(link => link.n1 == n1 & link.n2 == n2);
            if (rlink != null)
                return rlink.w;
            return 0;
        }

        public bool RemoveNode(int n)
        {
            this.RemoveAllLinks(n);

           return nodes.Remove(n);
        }

        public bool RemoveLink(int n1, int n2)
        {
            var linksToRemove = this.links.FindAll(link => link.n1 == n1 & link.n2 == n2);
            foreach (var l in linksToRemove)
            {
                this.links.Remove(l);
            }
            return (linksToRemove.Count > 0);

        }

        public void RemoveAllLinks(int n)
        {
            var linksToRemove = this.links.FindAll(link => link.n1 == n);
            foreach (var l in linksToRemove)
            {
                this.links.Remove(l);
            }

            linksToRemove = this.links.FindAll(link => link.n2 == n);
            foreach (var l in linksToRemove)
            {
                this.links.Remove(l);
            }
        }

        public List<Link> GetNeighbours(int n)
        {
            return this.links.FindAll(link => link.n1 == n).OrderBy(l => l.w).ToList<Link>();
        }
    }
}
