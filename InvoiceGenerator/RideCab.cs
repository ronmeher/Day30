using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class RideCab
    {
        // filds
        public double distance;
        public int time;

        public RideCab(double distance, int time) // Constructor
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
