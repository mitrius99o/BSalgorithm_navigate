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
                    break;
                case false:
                    while ((a.coef_comm.Intersect(b.coef_comm).Count() != 1)     //проверка на связь напрямую
                        & (a.name != b.name))
                    {
                        /*
                        if (b.coef_comm.Count() <= 2)                            //если В - линейный участок
                        {
                            if (!wayB.Contains(b))                               //и если нет В в списке нелинейного пути вблизи В
                                wayB.Add(b);                                     //то добавляем в этот список
                            b = NextPointByWay(b, wayB);                         //и идем к следующей точке от В и переопределяем ее
                        }
                        */

                        builder.BuildWayB(ref b);

                        if (a.coef_comm.Intersect(b.coef_comm).Count() == 1)//после некоторого количества итераций - проверка на прямую связь
                            break;
                        else                                                     //есди В входит в нелинейный участок
                        {
                            if (!builder.BuildWayA(ref a))
                            {
                                /*
                                for (int i = 0; (a.coef_comm.Intersect(b.coef_comm).Count() != 1)          //пока точки не связаны напрямую
                                     & (a.name != b.name); i++)
                                {
                                    if (!fork.Contains(b)) fork.Add(b);           //добавляем В "вилку"
                                    b = NextPointByFork(b, fork);                //и берем следующую точку по нелинейному участку, не важно по какому направлению
                                    if (fork.Count == 1)                           //если в "вилке" 1 элемент
                                        buferpoints.Push(b);                     //то запоминаем этот путь, добавляя В в buferpoints
                                    if (b == null)                               //если алгоритм зашел в тупик и не дошел до точки А 
                                    {
                                        int count = fork.Count;
                                        for (int j = 0; j < count - 1; j++)      //возвращаемся обратно по пройденному неправильному пути к точке-развилке
                                            fork.Remove(fork.Last());            //удаляя неправильный путь из "вилки" (удаляя точки)
                                        b = fork.Last();
                                    }
                                }
                                fork.Add(b);                                     //добавляем последнюю найденную точку В в "вилку"
                                fork.Add(a);                                     //и туда же добавляем А как нелинейный участок пути
                                */

                                builder.BuildWayFork(ref a, ref b);
                            }
                        }
                    }
                    /*
                    if (a == b && fork.Count == 0)                   //если А=В и путь не имел разветвлений          
                        wayA.Add(a);                                 //добавляем А в путь вблизи А
                    else if (fork.Count == 0)                           //иначе добавляем А, затем В
                    {
                        wayA.Add(a);
                        wayB.Add(b);
                    }
                    string resA = null;                               //чтобы правильно вывести на экран путь, объявляем строки 
                    string resB = null;                               //соответствующие 3м участкам пути: 2м линейным и 1 нелинейному
                    string resF = null;
                    for (int i = 0; i < wayA.Count; i++)
                    {
                        if (i == 0)
                            resA = wayA[i].name + " ";
                        else
                            resA += wayA[i].name + " ";
                    }
                    for (int i = fork.Count - 1; i >= 0; i--)
                    {
                        if (i == fork.Count)
                            resF = fork[i].name + " ";               //запись в переменные правильный порядок пути от А в В
                        else
                            resF += fork[i].name + " ";
                    }
                    for (int i = wayB.Count - 1; i > -1; i--)
                    {
                        if (i == wayB.Count - 1)
                            resB = wayB[i].name + " ";
                        else
                            resB += wayB[i].name + " ";
                    }
                    //}
                    return "Маршрут между точками " + ((wayA.Count() != 0) ? wayA.First().name : fork.First().name) +       //Вывод на экран
                        " и " + ((wayB.Count() != 0) ? wayB.First().name : fork.First().name) + ": " + resA + resF + resB;
                default:
                    return "Ошибка";
                    */
                    builder.GetWay(ref a, ref b);
                    break;
            }
        }
    }
}
