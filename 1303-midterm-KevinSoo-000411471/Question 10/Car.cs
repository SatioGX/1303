using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_midterm_KevinSoo_000411471.Question_10
{
    public class Car : Vehicle
    {
        public override int GetNumberOfWheels()
        {
            return 4;
        }

        public override int GetMaxSpeed()
        {
            return 250;
        }
    }
}
