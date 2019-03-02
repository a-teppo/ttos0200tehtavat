using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class Tank
    {
        //fields
        private string name;
        private string type;
        private int crewcount;
        private float speed;

        // properties
        private readonly float SpeedMax = 100;
        public string Name { get; set; }
        public string Type { get; set; }
        public int CrewCount
        {
            get
            {
                return crewcount;
            }
            set
            {
                if (value >= 2 && 6 >= value) crewcount = value;
                else
                    crewcount = 2;
            }
        }
        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value >= 0 && SpeedMax >= value) speed = value;
                else
                    speed = 0;
            }
        }

        public Tank(string name, string type, int crewcount)
        {
            Name = name;
            Type = type;
            CrewCount = crewcount;
        }

        public float AccerelateTo(int more)
        {
            Speed = more;
            return Speed;
        }

        public float SlowTo(int less)
        {
            Speed = less;
            return Speed;
        }
    }
}
