using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni2_Speed
{
    public class Speed
    {
        double distance;
        double time;
        double speed;

        //constructor
        public Speed(double distance, double time)
        {
            this.distance = distance;
            this.time = time;
            speed= 0;
            operacion();
        }
        public override string ToString()
        {
            return "the speed is: " + speed.ToString();
        }

        public void operacion ()
        {
          speed =  (distance / time);
        }

    }
}
