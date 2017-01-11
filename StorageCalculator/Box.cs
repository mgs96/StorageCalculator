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
        private string type;

        public Box(int linealMeter, string label, string type)
        {
            this.linearMeter = linealMeter;
            this.label = label;
            this.type = type;
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

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}