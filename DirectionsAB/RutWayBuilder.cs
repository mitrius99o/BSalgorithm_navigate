using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    public class RutWayBuilder : WayBuilder
    {
        public ResultWay resultWay = new ResultWay();

        public List<Point> wayA = new List<Point>();                        //если точки не связаны напрямую, то создаем 3 списка
        public List<Point> wayB = new List<Point>();                        //линейный путь от точки А к точке B, линейный путь от точки В к А
        public List<Point> fork = new List<Point>();                        //список "вилка" из точек, входящие в нелинейный участок пути 

        PointCommunications PC = new PointCommunications();          //после редактирования удалить и сделать этот класс статическим
        public override bool BuildWayA(ref Point a)
        {
            if (!wayA.Contains(a) && (a.coef_comm.Count() <= 2))
            {
                if (wayA.Count == 0 || wayB.Count == 0)
                {
                    wayA.Add(a);                                          //то уже идем от точки А, добавляя ее в коллекцию вблизи А
                    a = PointCommunications.NextPointByWay(a, wayA);      //и берем следующую точку по пути от А и переопределяем ее
                    return true;
                }
                else if (wayA.First() != wayB.Last())
                {
                    wayA.Add(a);
                    List<Point> buff = new List<Point>();
                    foreach (Point o in wayA) buff.Add(o);

                    a = wayA.First();
                    buff.Remove(wayA.First());
                    wayA.Clear();
                    wayA.Add(a);
                }
                else
                {
                    wayA.Add(a);                                     //то добавляем в этот список
                    a = PointCommunications.NextPointByWay(a, wayA);
                    return true;
                }
                return true;
            }
            else
                return false;

        }
        public override void BuildWayFork(ref Point a, ref Point b)
        {
            List<Point> buff = new List<Point>();
            PointCommunications.bufferPoints.Push(b);
            for (int i = 0; (a.coef_comm.Intersect(b.coef_comm).Count() != 1)          //пока точки не связаны напрямую
                                    & (a.Name != b.Name); i++)
            {
                
                if (!fork.Contains(b)) fork.Add(b);                                    //добавляем В "вилку"
                b = PointCommunications.NextPointByFork(b, fork.Union(buff).ToList());                      //и берем следующую точку по нелинейному участку, не важно по какому направлению
                if(b==null) { }
                else if(b.coef_comm.Count > 2)
                    PointCommunications.bufferPoints.Push(b);
                if (b == null)                               //если алгоритм зашел в тупик и не дошел до точки А 
                {
                    b = PointCommunications.bufferPoints.Peek();
                    while (b != fork.Last())
                    {
                        buff.Add(fork.Last());
                        fork.Remove(fork.Last());
                    }
                    b=(PointCommunications.NextPointByFork(b, fork.Union(buff).ToList())==null)?
                        PointCommunications.NextPointByFork(b, buff):
                        PointCommunications.NextPointByFork(b, fork.Union(buff).ToList());
                    if (b.coef_comm.Count > 2 && !PointCommunications.bufferPoints.Contains(b))
                        PointCommunications.bufferPoints.Push(b);
                    if (fork.Contains(b))
                    {
                        PointCommunications.bufferPoints.Pop();
                        while (b != fork.Last())
                        {
                            buff.Add(fork.Last());
                            fork.Remove(fork.Last());
                        }
                    }
                }
            }
            fork.Add(b);                                     //добавляем последнюю найденную точку В в "вилку"
            fork.Add(a);                                     //и туда же добавляем А как нелинейный участок пути
        }
        public override void BuildWayB(ref Point b)
        {
             if (b.coef_comm.Count() <= 2)                            //если В - линейный участок
             {
                //wayB.Add(b);
                if (!wayB.Contains(b))       //и если нет В в списке нелинейного пути вблизи В
                {
                    if (wayA.Count == 0 || wayB.Count == 0)
                    {
                        wayB.Add(b);                                     //то добавляем в этот список
                        b = PointCommunications.NextPointByWay(b, wayB);
                    }
                    else if(wayB.First() != wayA.Last())
                    {
                        wayB.Add(b);
                        List<Point> buff = new List<Point>();
                        foreach (Point o in wayB) buff.Add(o);

                        b = wayB.First();
                        buff.Remove(wayB.First());
                        wayB.Clear();
                        wayB.Add(b);
                    }
                    else
                    {
                        wayB.Add(b);                                     //то добавляем в этот список
                        b = PointCommunications.NextPointByWay(b, wayB);
                    }
                }
                else if(wayB.Count!=0&& b.coef_comm.Count() == 1)
                {
                    wayB.Add(b);
                    List<Point> buff = new List<Point>();
                    foreach (Point o in wayB) buff.Add(o);

                    b = wayB.First();
                    buff.Remove(wayB.First());
                    wayB.Clear();
                    wayB.Add(b);

                    b = PointCommunications.NextPointByWay(b, buff);

                    //берем другую точку, которая в другой стороне и не содержится в wayB
                }
                      //и идем к следующей точке от В и переопределяем ее
             }
        }
        public override ResultWay GetWay(ref Point a, ref Point b)
        {
            if (a == b && fork.Count == 0)                      //если А=В и путь не имел разветвлений          
                wayA.Add(a);                                    //добавляем А в путь вблизи А
            else if (fork.Count == 0)                           //иначе добавляем А, затем В
            {
                wayA.Add(a);
                wayB.Add(b);
            }
            for (int i = 0; i < wayA.Count; i++)
            {
                resultWay.Add(wayA[i]);
            }
            for (int i = fork.Count - 1; i >= 0; i--)
            {
                resultWay.Add(fork[i]);
            }
            for (int i = wayB.Count - 1; i > -1; i--)
            {
                resultWay.Add(wayB[i]);
            }
            foreach (Point p in this.resultWay.resultPoints)
            {
                Console.Write(p.Name + " ");
            }
            return resultWay;
        }
    }
}
