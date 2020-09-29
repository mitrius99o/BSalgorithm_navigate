using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    public class Point                                                            //класс, описывающий точку на карте
    {
        public string name;                                                //имя точки
        public List<int> coef_comm;                                        //список, который хранит ID каждой из связей точки
        public Point(string n) { name = n; coef_comm = new List<int>(); }  //конструктор для создания точки, в параметр подается строка,  
                                                                           //которая записывается в поле name
    }
}
