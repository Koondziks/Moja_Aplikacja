using System;
using System.Collections.Generic;
using System.Text;

namespace MojaAplikacja.Models
{
    public class Volume
    {
        //właściwości:
        
        // parametr V to Volume
        public double V { get;  private set; }
        public double R { get;  }
        public double H { get;  }

        public Volume(double r, double h)
        {
            R = r;
            H = h;

            //metoda obliczeniowa:
            Calculate();
        }

        private void Calculate()
        {
            V =  Math.PI * Math.Pow(R,2) * H; 
        }
    }
}
