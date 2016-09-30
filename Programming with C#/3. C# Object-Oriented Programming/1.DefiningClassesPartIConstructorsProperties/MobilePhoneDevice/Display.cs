using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Display
    {
        //Fields
        private double displaySize;
        private string displayColors;

        //Constructors
        public Display(double displaySize, string displayColors)
        {
            this.displaySize = displaySize;
            this.displayColors = displayColors;
        }

        //Properties
        public double DisplaySize
        {
            get { return displaySize; }
            set { displaySize = value; }
        }

        public string DisplayColors 
        {
            get { return displayColors; }
            set { displayColors = value; }
        }
    }
}
