using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DirectionsAB
{
    public class Point                                                   //класс, описывающий точку на карте
    {
        public static float coef = 2.36f;
        public string name;                                                //имя точки
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
        public Point(string n) { name = n; coef_comm = new List<int>(); }  //конструктор для создания точки, в параметр подается строка,  
                                                                           //которая записывается в поле name
        public Point(string n, float x, float y)
        {
            name = n;
            X = x;
            Y = y;
            coef_comm = new List<int>();
        }
    }
}
