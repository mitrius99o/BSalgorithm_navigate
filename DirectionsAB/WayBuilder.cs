using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    abstract class WayBuilder
    {
        public abstract void BuildWayA();
        public abstract void BuildWayFork();
        public abstract void BuildWayB();
        public abstract List<Point> GetWay();
    }
}
