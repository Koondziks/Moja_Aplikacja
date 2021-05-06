using System;
using System.Collections.Generic;
using System.Text;

namespace MojaAplikacja.Models
{
    public class CubeVolume
    {
        //właściwości:

        // parametr V to Volume
        public double CV { get; private set; }
        public double CA { get; }
        public double CB { get; }
        public double CH { get; }

        public CubeVolume(double ca, double cb, double ch)
        {
            CA = ca;
            CB = cb;
            CH = ch;

            //metoda obliczeniowa:
            CubeCalculate();
        }

        private void CubeCalculate()
        {
            CV = CA * CB * CH;
        }
    }
}
