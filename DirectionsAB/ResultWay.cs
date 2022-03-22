using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    public class ResultWay
    {
        public List<Point> resultPoints = new List<Point>();
        public void Add(Point point)
        {
            resultPoints.Add(point);
        }
    }
}
