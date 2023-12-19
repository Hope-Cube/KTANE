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
            public static string Description()
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
            public static string Correct(Point id, Point s, Point e)
            {
                return AStar.Path(id, s, e);
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