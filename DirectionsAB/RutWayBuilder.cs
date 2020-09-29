using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    class RutWayBuilder : WayBuilder
    {
        ResultWay resultWay = new ResultWay();
        public override void BuildWayA()
        {
            throw new NotImplementedException();
        }
        public override void BuildWayFork()
        {
            throw new NotImplementedException();
        }
        public override void BuildWayB(Point a, Point b, List<Point> wayB)
        {
            while ((a.coef_comm.Intersect(b.coef_comm).Count() != 1)     //проверка на связь напрямую
                        & (a.name != b.name))
            {
                if (b.coef_comm.Count() <= 2)                            //если В - линейный участок
                {
                    if (!wayB.Contains(b))                               //и если нет В в списке нелинейного пути вблизи В
                        wayB.Add(b);                                     //то добавляем в этот список
                    b = NextPointByWay(b, wayB);                         //и идем к следующей точке от В и переопределяем ее
                }
            }
        }
        public override List<Point> GetWay()
        {
            throw new NotImplementedException();
        }
    }
}
