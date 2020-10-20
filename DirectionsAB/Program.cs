using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DirectionsAB.PointCommunications;

namespace DirectionsAB
{
    class Program
    {
        public static void CreateTestTree(int count)
        {
            CreatePoints(count);

            Communicate(points[0], points[1]);
            Communicate(points[1], points[4]);
            Communicate(points[4], points[2]);
            Communicate(points[4], points[3]);
            Communicate(points[4], points[5]);
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            /*
            CreateTestTree(6);

            RutWayBuilder builder = new RutWayBuilder();
            Director director = new Director(builder);

            director.Construct(points[5], points[3]);

            foreach(Point p in builder.resultWay.resultPoints)
            {
                Console.Write(p.name + " ");
            }

            Console.ReadKey();
            */
        }
    }
}
