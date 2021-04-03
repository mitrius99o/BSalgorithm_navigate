using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.Linq.Mapping;
using DirectionsAB.Models;

namespace DirectionsAB
{
    public class Point: DirectionsAB.Models.Region                            //класс, описывающий точку на карте
    {
        public static float coef = Form1.coef;                                  //имя точки
        private float x, y;                                                     //координаты центра области аудитории/локации(декартовы)

        public float X
        {
            get { return x*coef; }
            set { x = value; }
        }
        public float Y
        {
            get { return y*coef; }
            set { y = value; }
        }
        
        public System.Drawing.Point p1;                                    //верхняя левая граница области
        public System.Drawing.Point p2;                                    //правая нижняя граница области

        public List<int> coef_comm;                                        //список, который хранит ID каждой из связей точки
        public Point() { }
        public Point(string n) { Name = n; coef_comm = new List<int>(); }  //конструктор для создания точки, в параметр подается строка,  
                                                                           //которая записывается в поле name
        public Point(string n, int x1, int y1, int x2, int y2)
        {
            Name = n;
            X1 = p1.X = x1;
            Y1 = p1.Y = y1;
            X2 = p2.X = x2;
            Y2 = p2.Y = y2;

            x = x1 + (x2 - x1) / 2;
            y = y1 + (y2 - y1) / 2;

            coef_comm = new List<int>();
        }
    }
}
