using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTANE
{
    /// <summary>
    /// Timed modules that must do in time.
    /// </summary>
    internal class Needy_module
    {
        /// <summary>
        /// Yes or No questions.
        /// </summary>
        public class Venting_gas
        {
            public string Description()
            {
                return "Answer the questions!";
            }
        }
        /// <summary>
        /// Discharging the capacitor.
        /// </summary>
        public class Capacitor_discharge
        {
            public string Description()
            {
                return "Hold down the lever!";
            }
        }
        /// <summary>
        /// Rotate the knob.
        /// </summary>
        public class Knobs
        {
            public string Description()
            {
                return "The knob must be in the correct position at the time!"; 
            }
            public string Position(bool[] leds)
            {
                if ((leds[0] == false && leds[1] == false && leds[2] == true && leds[3] == false && leds[4] == true && leds[5] == true && leds[6] == true && leds[7] == true && leds[8] == true) || 
                    (leds[0] == true && leds[1] == false && leds[2] == true && leds[3] == false && leds[4] == true && leds[5] == false && leds[6] == false && leds[7] == true && leds[8] == true))
                {
                    return "Up position!";
                }
                if ((leds[0] == false && leds[1] == true && leds[2] == true && leds[3] == false && leds[4] == false && leds[5] == true && leds[6] == true && leds[7] == true && leds[8] == true) || 
                    (leds[0] == true && leds[1] == false && leds[2] == true && leds[3] == false && leds[4] == true && leds[5] == false && leds[6] == false && leds[7] == true && leds[8] == false))
                {
                    return "Down position!";
                }
                if ((leds[0] == false && leds[1] == false && leds[2] == false && leds[3] == false && leds[4] == true && leds[5] == false && leds[6] == true && leds[7] == false && leds[8] == false) || 
                    (leds[0] == false && leds[1] == false && leds[2] == false && leds[3] == false && leds[4] == true && leds[5] == false && leds[6] == false && leds[7] == false && leds[8] == false))
                {
                    return "Left position!";
                }
                if ((leds[0] == true && leds[1] == false && leds[2] == true && leds[3] == true && leds[4] == true && leds[5] == true && leds[6] == true && leds[7] == true && leds[8] == true) ||
                    (leds[0] == true && leds[1] == false && leds[2] == true && leds[3] == true && leds[4] == false && leds[5] == false && leds[6] == true && leds[7] == true && leds[8] == true))
                {
                    return "Right position!";
                }
                return "Impossible position!";
            }        
        }
    }
}
