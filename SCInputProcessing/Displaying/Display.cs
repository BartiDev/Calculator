using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Displaying
{
    public class Display
    {
        Calculator c;

        public Display(Calculator calculator)
        {
            c = calculator;
        }

        public string SendDisplay()
        {
            return string.Join("", c.inputSequence);
        }
    }
}
