using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    abstract class WayBuilder
    {
        public abstract bool BuildWayA(ref Point a);
        public abstract void BuildWayFork(ref Point a, ref Point b);
        public abstract void BuildWayB(ref Point b);
        public abstract ResultWay GetWay(ref Point a, ref Point b);
    }
}
