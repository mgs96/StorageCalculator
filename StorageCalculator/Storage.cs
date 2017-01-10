using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageCalculator
{
    
    public class Storage
    {
        private int linearMeterCapacity;
        private int squareMeterCapacity;
        private int occupiedCapacity;
        private string name;
        private List<Box> boxes;

        public Storage(string name, int linearMeterCapacity)
        {
            this.name = name;
            this.linearMeterCapacity = linearMeterCapacity;
            this.occupiedCapacity = 0;
            boxes = new List<Box>();
        }

        public int LinearMeterCapacity
        {
            get { return linearMeterCapacity; }
            set { linearMeterCapacity = value; }
        }

        public int SquareMeterCapacity
        {
            get { return squareMeterCapacity; }
            set { squareMeterCapacity = value; }
        }

        public int OccupiedCapacity
        {
            get { return occupiedCapacity; }
            set { occupiedCapacity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Box> Boxes
        {
            get { return boxes; }
            set { boxes = value; }
        }

        public void AddBox(Box b)
        {
            boxes.Add(b);
        }

        public Box ReturnBox(string label)
        {
            return boxes.Find(x => x.Label.Contains(label));
        }
    }
}
