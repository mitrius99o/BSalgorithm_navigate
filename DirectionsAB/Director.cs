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
        public void Construct(Point a, Point b)
        {
            switch (a.coef_comm.Intersect(b.coef_comm).Count() == 1)
            {
                case true:
                    builder.BuildWayA(ref a);
                    builder.BuildWayB(ref b);
                    builder.GetWay(ref a, ref b);
                    break;
                case false:
                    while ((a.coef_comm.Intersect(b.coef_comm).Count() != 1)
                        & (a.Name != b.Name))
                    {
                        builder.BuildWayB(ref b);

                        if (a.coef_comm.Intersect(b.coef_comm).Count() == 1)
                            break;
                        else                                                
                        {
                            if (!builder.BuildWayA(ref a))
                            {
                                builder.BuildWayFork(ref a, ref b);
                            }
                        }
                    }
                    builder.GetWay(ref a, ref b);
                    break;
            }
        }
    }
}
