using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectionsAB.Models;
using System.Data.Entity;

namespace DirectionsAB
{
    public class PointCommunications                             //класс, описывающий связи между точками
    {
        static MapContext context=new MapContext();

        public static List<Point> points = new List<Point>();    //список, который хранит все точки на карте
        public static List<int> use_coef_comm = new List<int>(); //список, который хранит все уникальные и используемые ID связей между точками
        public static Stack<Point> bufferPoints = new Stack<Point>();
        public static void CreatePoints(int count)               //метод для создания набора точек
        {
            for (int i = 0; i < count; i++)
                points.Add(new Point($"{i}"));            //в качестве параметра в метод передается колво точек,  
        }                                                 //а с помощью for в список points добавляются эти точки

        public static bool CreatePoint(System.Drawing.Point start, System.Drawing.Point finish)
        {
            //float xc = start.X + (finish.X - start.X)/2;
            //float yc = start.Y + (finish.Y - start.Y)/2;
            if (start.X + (finish.X - start.X) / 2 > 0 && start.Y + (finish.Y - start.Y) / 2 > 0)
            {
                Point p = new Point($"{points.Count}", start.X, start.Y, finish.X, finish.Y);

                points.Add(p);

                context.Regions.Add(p);//Я изменил адрес базы данных
                context.SaveChanges();

                return true;
            }
            else
            {
                MessageBox.Show("Неправильно выбрана область!");
                return false;
            }
        }
        public static void Communicate(Point a, Point b)  //метод для создания связи между 2мя точками
        {
            Random r = new Random();                      
            int random_coef = r.Next();                   //создание экземпляра класса Random, с помощью Next() иниц. новый ID
            while (use_coef_comm.Contains(random_coef))   //используем новый ID только тогда, когда нет совпадения с использующимися 
                random_coef = r.Next();
            if (a.coef_comm == null) a.coef_comm = new List<int>();
            if (b.coef_comm == null) b.coef_comm = new List<int>();
            a.coef_comm.Add(random_coef);                 //добавляем уникальный ID в коллекции
            b.coef_comm.Add(random_coef);                 //обеих точек, тем самым достигая их "связки"

            Communication c1 = new Communication();
            Communication c2 = new Communication();

            c1.CommID = c2.CommID = random_coef;
            c1.RegionID = a.RegionId;
            c2.RegionID = b.RegionId;

            context.Communications.Add(c1);
            context.Communications.Add(c2);

            context.SaveChanges();

            use_coef_comm.Add(random_coef);               //добавляем уникальный ID в коллекцию используемых

            Console.WriteLine($"Cвязь между точками {a.Name} и {b.Name} создана. ID связи: {random_coef}");
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
                        && x != point                                //эта точка не равна поданной в параметр
                        && !way.Contains(x));                        //этой точки нет в  коллекции-пути
        }
        public static Point NextPointByFork(Point point, List<Point> way)   //возвращает след точку на нелинейном участке пути
        {
            return points.Find(x => IsCommunicated(point, x)    //с помощью метода-расширения Find ищется точка, имеющая прямой путь с поданной в параметр 
                        && x != point                                 //эта точка не равна поданной в параметр
                        && (x.coef_comm.Count() != 1)                 //проверяемая точка не должна быть тупиком
                        && !bufferPoints.Contains(x)                   //она не содержится в коллекции проверенных путей buferpoints
                        && !way.Contains(x));                         //этой точки нет в  коллекции-пути
        }
    }
}
