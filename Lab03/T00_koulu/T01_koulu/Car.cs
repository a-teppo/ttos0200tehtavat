using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Car
    {
        // fields
        private int speed;
        private const int maxSpeed = 200; //vakio
        //properties
        public int Speed { get { return speed; } }
        //constructors ei tarvita
        //methods
        public bool Accelerate(int more)
        {
            if (speed + more > maxSpeed)
            {
                speed = maxSpeed;
                return false;
            }
            else
            {
                speed = speed + more;
                return true;
            }
        }

        public void Brake(int less)
        {
            if (speed - less < 0)
            {
                speed = 0;
            }
            else
            {
                speed = speed - less;
            }
        }

    }
}
