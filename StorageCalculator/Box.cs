using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageCalculator
{

    public class Box
    {
        private int linearMeter;
        private int squareMeter;
        private string label;

        public Box(int linealMeter)
        {
            this.linearMeter = linealMeter;
            this.label = linealMeter.ToString();
        }

        public Box(int linealMeter, int squareMeter)
        {
            this.linearMeter = linealMeter;
            this.squareMeter = squareMeter;
        }

        public int LinealMeter
        {
            get { return linearMeter; }
            set { linearMeter = value; }
        }

        public int SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
    }
}
