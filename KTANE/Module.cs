using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace KTANE
{
    /// <summary>
    /// Simple modules, solve it.
    /// </summary>
    internal class Module
    {
        /// <summary>
        /// Cut the correct one.
        /// </summary>
        public class Wires
        {
            public string Description()
            {
                return "Cut the correct wire to solve this one!";
            }
        }
        /// <summary>
        /// Handle the button.
        /// </summary>
        public class Button
        {

        }
        /// <summary>
        /// Push the symbols in the correct order.
        /// </summary>
        public class Keypads
        {

        }
        /// <summary>
        /// Simon says.
        /// </summary>
        public class Simon_says
        {

        }
        /// <summary>
        /// Push the correct word.
        /// </summary>
        public class Whos_on_first
        {

        }
        /// <summary>
        /// Push the correct number.
        /// </summary>
        public class Memory
        {

        }
        /// <summary>
        /// Find the frequency.
        /// </summary>
        public class Morse_code
        {

        }
        /// <summary>
        /// Cut the correct one.
        /// </summary>
        public class Comp_wires
        {

        }
        /// <summary>
        /// Cut the correct one.
        /// </summary>
        public class Wire_seqs
        {

        }
        /// <summary>
        /// Find the spot.
        /// </summary>
        public class Maze
        {
            public string Correct(Point f, Point s, Point b, Point e)
            {
                // Create a 2D array to represent the grid
                AStarNode[,] grid = new AStarNode[11, 11];

                // Initialize the grid with nodes
                for (int x = 0; x < 11; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        grid[x, y] = new AStarNode(x, y);
                    }
                }

                List<Point> points = new List<Point>();

                if ((f == new Point(0, 1) && s == new Point(5, 2)) || (f == new Point(5, 2) && s == new Point(0, 1)))
                {
                    points.AddRange(new List<Point> { new Point(6, 0), new Point(6, 0) });
                }
                if ((f == new Point(3, 1) && s == new Point(4, 1)) || (f == new Point(4, 1) && s == new Point(3, 1)))
                {

                }
                if ((f == new Point(3, 3) && s == new Point(5, 3)) || (f == new Point(5, 3) && s == new Point(3, 3)))
                {

                }
                if ((f == new Point(0, 0) && s == new Point(5, 2)) || (f == new Point(5, 2) && s == new Point(0, 0)))
                {

                }
                if ((f == new Point(3, 5) && s == new Point(4, 2)) || (f == new Point(4, 2) && s == new Point(3, 5)))
                {

                }
                if ((f == new Point(4, 0) && s == new Point(2, 4)) || (f == new Point(2, 4) && s == new Point(4, 0)))
                {

                }
                if ((f == new Point(1, 0) && s == new Point(1, 5)) || (f == new Point(1, 5) && s == new Point(1, 0)))
                {

                }
                if ((f == new Point(3, 0) && s == new Point(2, 3)) || (f == new Point(2, 3) && s == new Point(3, 0)))
                {

                }
                if ((f == new Point(2, 1) && s == new Point(0, 4)) || (f == new Point(0, 4) && s == new Point(2, 1)))
                {

                }

                // Mark obstacles in the grid
                foreach (Point point in points)
                {
                    int x = (int)point.X;
                    int y = (int)point.Y;

                    // Ensure the indices are within the bounds of the bool array
                    if (x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1))
                    {
                        grid[x, y].IsObstacle = true;
                    }
                }

                // Define the start and end nodes
                AStarNode startNode = grid[(int)b.X, (int)b.Y];
                AStarNode endNode = grid[(int)e.X, (int)e.Y];

                // Find the path using A* algorithm
                List<AStarNode> path = AStar.FindPath(startNode, endNode);

                // Print the path
                if (path != null)
                {
                    foreach (var node in path)
                    {
                        Console.WriteLine($"({node.X}, {node.Y})");
                    }
                    return "Path found:";
                }
                else
                {
                    return "No path found.";
                }
                
            }
        }
        /// <summary>
        /// Input tthe correct password.
        /// </summary>
        public class Passwords
        {

        }
    }
}
