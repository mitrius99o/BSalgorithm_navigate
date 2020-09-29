using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    public class PointCommunications                             //класс, описывающий связи между точками
    {
        public static List<Point> points = new List<Point>();    //список, который хранит все точки на карте
        public static List<int> use_coef_comm = new List<int>(); //список, который хранит все уникальные и используемые ID связей между точками
        public static Stack<Point> bufferPoints = new Stack<Point>();
        public static void CreatePoints(int count)               //метод для создания набора точек
        {
            for (int i = 0; i < count; i++)
                points.Add(new Point($"{i}"));            //в качестве параметра в метод передается колво точек,  
        }                                                 //а с помощью for в список points добавляются эти точки
        public static void Communicate(Point a, Point b)         //метод для создания связи между 2мя точками
        {
            Random r = new Random();                      
            int random_coef = r.Next();                   //создание экземпляра класса Random, с помощью Next() иниц. новый ID
            while (use_coef_comm.Contains(random_coef))   //используем новый ID только тогда, когда нет совпадения с использующимися 
                random_coef = r.Next();
            a.coef_comm.Add(random_coef);                 //добавляем уникальный ID в коллекции
            b.coef_comm.Add(random_coef);                 //обеих точек, тем самым достигая их "связки"
            use_coef_comm.Add(random_coef);               //добавляем уникальный ID в коллекцию используемых
            Console.WriteLine($"Cвязь между точками {a.name} и {b.name} создана. ID связи: {random_coef}");
        }

        

        public static bool IsCommunicated(Point a, Point b)      //метод, возвращающий логическое значение для определения того,
        {                                                 //есть ли прямой путь между двумя точками, подающимися в параметр
            IEnumerable<int> check = new Stack<int>();    
            check = a.coef_comm.Intersect(b.coef_comm);   //в коллекцию записывается количество общих ID связи у проверяемых точек
            if (check.Count() == 1)                       //если количество=1, то связь есть
                return true;
            else
                return false;                             //иначе связи нет
        }
        public static Point NextPointByWay(Point point, List<Point> way)   //возвращает след точку на линейном участке пути       
        {                                                           
            return points.Find(x => IsCommunicated(point, x)   //с помощью метода-расширения Find ищется точка, имеющая прямой путь с поданной в параметр
                        & x != point                                //эта точка не равна поданной в параметр
                        & !way.Contains(x));                        //этой точки нет в  коллекции-пути
        }
        public static Point NextPointByFork(Point point, List<Point> way)   //возвращает след точку на нелинейном участке пути
        {
            return points.Find(x => IsCommunicated(point, x)    //с помощью метода-расширения Find ищется точка, имеющая прямой путь с поданной в параметр 
                        & x != point                                 //эта точка не равна поданной в параметр
                        & (x.coef_comm.Count() != 1)                 //проверяемая точка не должна быть тупиком
                        & !bufferPoints.Contains(x)                   //она не содержится в коллекции проверенных путей buferpoints
                        & !way.Contains(x));                         //этой точки нет в  коллекции-пути
        }
        /*
        public string GetWayAB(Point a, Point b)                                 //метод, находящий путь между 2мя точками         
        { 
            switch (a.coef_comm.Intersect(b.coef_comm).Count() == 1)             
            {
                case true:
                    return "Маршрут между точками "+a.name +"и"+ b.name+": "+a.name + b.name; 
                case false:                                      
                    List<Point> wayA = new List<Point>();                        //если точки не связаны напрямую, то создаем 3 списка
                    List<Point> wayB = new List<Point>();                        //линейный путь от точки А к точке B, линейный путь от точки В к А
                    List<Point> fork = new List<Point>();                        //список "вилка" из точек, входящие в нелинейный участок пути 
                    while ((a.coef_comm.Intersect(b.coef_comm).Count() != 1)     //проверка на связь напрямую
                        & (a.name != b.name))
                    {
                        if (b.coef_comm.Count() <= 2)                            //если В - линейный участок
                        {
                            if (!wayB.Contains(b))                               //и если нет В в списке нелинейного пути вблизи В
                                wayB.Add(b);                                     //то добавляем в этот список
                            b = NextPointByWay(b, wayB);                         //и идем к следующей точке от В и переопределяем ее
                        }

                        

                        else if (a.coef_comm.Intersect(b.coef_comm).Count() == 1)//после некоторого количества итераций - проверка на прямую связь
                            break;
                        else                                                     //есди В входит в нелинейный участок
                        {
                            if (!wayA.Contains(a) && (a.coef_comm.Count() <= 2))
                            {
                                wayA.Add(a);                                     //то уже идем от точки А, добавляя ее в коллекцию вблизи А
                                a = NextPointByWay(a, wayA);                     //и берем следующую точку по пути от А и переопределяем ее
                            }
                            else                                                 //если выяснилось, что А входит в нелинейный участок
                            {
                                for (int i = 0; (a.coef_comm.Intersect(b.coef_comm).Count() != 1)          //пока точки не связаны напрямую
                                    & (a.name != b.name); i++)
                                {
                                    if(!fork.Contains(b)) fork.Add(b);           //добавляем В "вилку"
                                    b = NextPointByFork(b, fork);                //и берем следующую точку по нелинейному участку, не важно по какому направлению
                                    if (fork.Count==1)                           //если в "вилке" 1 элемент
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
                            }

                        }
                    }
                    if (a == b && fork.Count == 0)                   //если А=В и путь не имел разветвлений          
                        wayA.Add(a);                                 //добавляем А в путь вблизи А
                    else if(fork.Count==0)                           //иначе добавляем А, затем В
                    {
                        wayA.Add(a);
                        wayB.Add(b);
                    }
                    string resA =null;                               //чтобы правильно вывести на экран путь, объявляем строки 
                    string resB= null;                               //соответствующие 3м участкам пути: 2м линейным и 1 нелинейному
                    string resF = null;
                    for (int i = 0; i < wayA.Count; i++)
                    {
                        if (i == 0)
                            resA = wayA[i].name + " ";
                        else
                            resA += wayA[i].name + " ";
                    }
                    for(int i=fork.Count-1; i>=0; i--)
                    {
                        if (i== fork.Count)
                            resF = fork[i].name + " ";               //запись в переменные правильный порядок пути от А в В
                        else
                            resF += fork[i].name + " ";
                    }
                    for(int i=wayB.Count-1; i>-1; i--)
                    {
                        if (i == wayB.Count - 1)
                            resB = wayB[i].name + " ";
                        else
                            resB += wayB[i].name + " ";
                    }
                    //}
                    return "Маршрут между точками " + ((wayA.Count()!=0)? wayA.First().name : fork.First().name)+       //Вывод на экран
                        " и " + ((wayB.Count()!=0)? wayB.First().name : fork.First().name) + ": " + resA + resF + resB;
                default:
                    return "Ошибка";
                    /*if (c != b)
                            {
                                //Console.WriteLine(b.coef_comm.Count());
                                if (b.coef_comm.Count() > 2)
                                    fork.Push(b);
                                if ((b.coef_comm.Count() == 1)/*&&(wayB.Count()>1))
                                    while (b != fork.Peek())
                                    {
                                        c = b;
                                        b = this.points.Find(x => (x.coef_comm.Intersect(c.coef_comm).Count() == 1) & x != c);
                                        wayB.Remove(c);
                                    }
                            }
                                
            } 
        } */
    }
}
