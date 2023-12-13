using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE
{
    internal class AStarNode
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsObstacle { get; set; }
        public List<AStarNode> Neighbors { get; set; }
        public AStarNode Parent { get; set; }
        public int GCost { get; set; }
        public int HCost { get; set; }
        public int FCost => GCost + HCost;

        public AStarNode(int x, int y, bool isObstacle = false)
        {
            X = x;
            Y = y;
            IsObstacle = isObstacle;
            Neighbors = new List<AStarNode>();
        }
    }
}
