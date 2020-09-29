using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    class Director
    {
        WayBuilder builder;
        public Director(WayBuilder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildWayA();
            builder.BuildWayFork();
            builder.BuildWayB();
        }
    }
}
