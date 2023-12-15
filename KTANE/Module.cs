using AStarPath;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using static System.Console;

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
            public string Correct(Point f, Point b, Point e)
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

                if (f == new Point(0, 1) || f == new Point(5, 2))
                {
                    points = GetObsticles(0, 0);
                }
                if (f == new Point(3, 1) || f == new Point(4, 1))
                {
                    points = GetObsticles(1, 0);
                }
                if (f == new Point(3, 3) || f == new Point(5, 3))
                {
                    points = GetObsticles(2, 0);
                }
                if (f == new Point(0, 0) || f == new Point(5, 2))
                {
                    points = GetObsticles(0, 1);
                }
                if (f == new Point(3, 5) || f == new Point(4, 2))
                {
                    points = GetObsticles(1, 1);
                }
                if (f == new Point(4, 0) || f == new Point(2, 4))
                {
                    points = GetObsticles(2, 1);
                }
                if (f == new Point(1, 0) || f == new Point(1, 5))
                {
                    points = GetObsticles(0, 2);
                }
                if (f == new Point(3, 0) || f == new Point(2, 3))
                {
                    points = GetObsticles(1, 2);
                }
                if (f == new Point(2, 1) || f == new Point(0, 4))
                {
                    points = GetObsticles(2, 2);
                }

                // Mark obstacles in the grid
                foreach (Point point in points)
                {
                    grid[point.X, point.Y].IsObstacle = true;
                }

                // Define the start and end nodes
                AStarNode startNode = grid[b.X, b.Y];
                AStarNode endNode = grid[e.X, e.Y];

                // Find the path using A* algorithm
                List<AStarNode> path = AStar.FindPath(startNode, endNode);

                string s = "";

                // Print the path
                if (path != null)
                {
                    /*WriteLine("Path found:");
                    Bitmap pathBitmap = new Bitmap(11, 11);*/
                    for (int i = 0; i < path.Count - 1; i += 2)
                    {
                        AStarNode currentNode = path[i];
                        AStarNode nextNode = (i + 1 < path.Count) ? path[i + 1] : null;
                        int dx = (nextNode != null) ? nextNode.X - currentNode.X : 0;
                        int dy = (nextNode != null) ? nextNode.Y - currentNode.Y : 0;
                        string direction = GetDirection(dx, dy);
                        //WriteLine($"{direction}");
                        s += direction;
                        /*pathBitmap.SetPixel(currentNode.X, currentNode.Y, Color.FromArgb(0, 255, 255));
                        if (nextNode != null)
                        {
                            pathBitmap.SetPixel(nextNode.X, nextNode.Y, Color.FromArgb(0, 255, 255));
                        }*/
                    }
                    /*// Add the last node to the bitmap
                    pathBitmap.SetPixel(path.Last().X, path.Last().Y, Color.FromArgb(0, 255, 255));
                    pathBitmap.Save("path.png");*/
                }
                else
                {
                    System.Windows.MessageBox.Show("No path found.", "Warning");
                }
                return s;
            }
            private string GetDirection(int dx, int dy)
            {
                if (dx == 1)
                {
                    return "→";
                }
                else if (dx == -1)
                {
                    return "←";
                }
                else if (dy == 1)
                {
                    return "↓";
                }
                else if (dy == -1)
                {
                    return "↑";
                }
                return "unknown";
            }
            private List<Point> GetObsticles(int sx, int sy)
            {
                int xx = sx * 11;
                int yy = sy * 11;
                List<Point> obs;
                using (Bitmap field = new Bitmap("field.png"))
                {
                    obs = new List<Point>();
                    for (int x = xx; x < xx + 11; x++)
                    {
                        for (int y = yy; y < yy + 11; y++)
                        {
                            if (field.GetPixel(x, y) == Color.FromArgb(0, 0, 0))
                            {
                                obs.Add(new Point(x, y));
                            };
                        }
                    }
                }
                return obs;
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
