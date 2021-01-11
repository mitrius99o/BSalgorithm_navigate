using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.Linq.Mapping;

namespace DirectionsAB
{
    public class Point:Room                                                   //класс, описывающий точку на карте
    {
        public static float coef = 2.36f;
        public int Id { get; set; }
        public string Name { get; set; }                                                //имя точки
        private float x, y;                                                 //координаты центра области аудитории/локации(декартовы)

        public float X
        {
            get { return x * coef; }
            set { x = value; }
        }
        public float Y
        {
            get { return y * coef; }
            set { y = value; }
        }
        
        public System.Drawing.Point p1;                                    //верхняя левая граница области
        public System.Drawing.Point p2;                                    //правая нижняя граница области

        public List<int> coef_comm;                                        //список, который хранит ID каждой из связей точки
        public Point() { }
        public Point(string n) { Name = n; coef_comm = new List<int>(); }  //конструктор для создания точки, в параметр подается строка,  
                                                                           //которая записывается в поле name
        public Point(string n, float x, float y)
        {
            Name = n;
            X = x;
            Y = y;
            coef_comm = new List<int>();
        }
    }
}
