using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPrim
{
    public static class MSTAlgorithms
    {
        public static List<int> Prim(Graph g)
        {
            List<int> result = new List<int>();
            result.Add(1);
            while(result.Count <= g.NodesCount()){
                var node = FindMin(g, result);
                result.Add(node);
            }

            return result;
        }

        private static int FindMin(Graph g, List<int> result)
        {
            var neighbours = new List<Link>();
            foreach (var n in result)
            {
                neighbours.AddRange(g.GetNeighbours(n));
            }
            var possibleNeighbours = neighbours.FindAll(link => !result.Contains(link.n2)).OrderBy(link => link.w).ToList<Link>();
            return possibleNeighbours.FirstOrDefault().n2;
        }

    }
}
