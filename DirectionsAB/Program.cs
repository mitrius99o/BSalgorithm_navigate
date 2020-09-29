using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    class Program
    {
        public static void CreateSapFloor(PointCommunications pc)
        {
            pc.CreatePoints(80);

            pc.Communicate(pc.points[0], pc.points[1]);
            pc.Communicate(pc.points[1], pc.points[2]);
            pc.Communicate(pc.points[2], pc.points[3]);
            pc.Communicate(pc.points[3], pc.points[4]);
            pc.Communicate(pc.points[4], pc.points[5]);
            pc.Communicate(pc.points[5], pc.points[6]);
            pc.Communicate(pc.points[6], pc.points[7]);
            pc.Communicate(pc.points[7], pc.points[8]);
            pc.Communicate(pc.points[8], pc.points[9]);
            pc.Communicate(pc.points[9], pc.points[10]);
            pc.Communicate(pc.points[10], pc.points[11]);
            pc.Communicate(pc.points[11], pc.points[12]);
            pc.Communicate(pc.points[12], pc.points[13]);     //коридор
            pc.Communicate(pc.points[13], pc.points[14]);
            pc.Communicate(pc.points[14], pc.points[15]);
            pc.Communicate(pc.points[15], pc.points[16]);
            pc.Communicate(pc.points[16], pc.points[17]);
            pc.Communicate(pc.points[17], pc.points[18]);
            pc.Communicate(pc.points[18], pc.points[19]);
            pc.Communicate(pc.points[19], pc.points[20]);
            pc.Communicate(pc.points[20], pc.points[21]);
            pc.Communicate(pc.points[21], pc.points[22]);
            pc.Communicate(pc.points[22], pc.points[23]);
            pc.Communicate(pc.points[23], pc.points[24]);


            pc.Communicate(pc.points[0], pc.points[25]);
            pc.Communicate(pc.points[1], pc.points[26]);
            pc.Communicate(pc.points[2], pc.points[27]);
            pc.Communicate(pc.points[3], pc.points[28]);
            pc.Communicate(pc.points[4], pc.points[29]);
            pc.Communicate(pc.points[5], pc.points[30]);
            pc.Communicate(pc.points[6], pc.points[32]);
            pc.Communicate(pc.points[32], pc.points[31]);
            pc.Communicate(pc.points[7], pc.points[33]);
            pc.Communicate(pc.points[33], pc.points[34]);
            pc.Communicate(pc.points[8], pc.points[35]);         //аудитории северной стороны
            pc.Communicate(pc.points[9], pc.points[36]);
            pc.Communicate(pc.points[11], pc.points[37]);
            pc.Communicate(pc.points[12], pc.points[40]);
            pc.Communicate(pc.points[40], pc.points[38]);
            pc.Communicate(pc.points[40], pc.points[41]);
            pc.Communicate(pc.points[13], pc.points[41]);
            pc.Communicate(pc.points[41], pc.points[39]);
            pc.Communicate(pc.points[14], pc.points[42]);
            pc.Communicate(pc.points[16], pc.points[43]);
            pc.Communicate(pc.points[17], pc.points[45]);
            pc.Communicate(pc.points[45], pc.points[44]);
            pc.Communicate(pc.points[45], pc.points[79]);
            pc.Communicate(pc.points[79], pc.points[46]);
            pc.Communicate(pc.points[20], pc.points[47]);
            pc.Communicate(pc.points[21], pc.points[48]);
            pc.Communicate(pc.points[22], pc.points[49]);
            pc.Communicate(pc.points[23], pc.points[50]);
            pc.Communicate(pc.points[24], pc.points[51]);


            pc.Communicate(pc.points[1], pc.points[52]);
            pc.Communicate(pc.points[2], pc.points[53]);
            pc.Communicate(pc.points[3], pc.points[54]);
            pc.Communicate(pc.points[4], pc.points[55]);
            pc.Communicate(pc.points[5], pc.points[56]);
            pc.Communicate(pc.points[6], pc.points[57]);
            pc.Communicate(pc.points[7], pc.points[59]);
            pc.Communicate(pc.points[59], pc.points[58]);
            pc.Communicate(pc.points[9], pc.points[60]);
            pc.Communicate(pc.points[10], pc.points[61]);
            pc.Communicate(pc.points[11], pc.points[62]);
            pc.Communicate(pc.points[12], pc.points[63]);
            pc.Communicate(pc.points[63], pc.points[64]);
            pc.Communicate(pc.points[64], pc.points[66]);
            pc.Communicate(pc.points[66], pc.points[65]);     //аудитории южной стороны
            pc.Communicate(pc.points[66], pc.points[67]);
            pc.Communicate(pc.points[67], pc.points[68]);
            pc.Communicate(pc.points[13], pc.points[66]);
            pc.Communicate(pc.points[15], pc.points[69]);
            pc.Communicate(pc.points[16], pc.points[70]);
            pc.Communicate(pc.points[17], pc.points[72]);
            pc.Communicate(pc.points[72], pc.points[71]);
            pc.Communicate(pc.points[18], pc.points[73]);
            pc.Communicate(pc.points[19], pc.points[74]);
            pc.Communicate(pc.points[20], pc.points[75]);
            pc.Communicate(pc.points[21], pc.points[76]);
            pc.Communicate(pc.points[22], pc.points[77]);
            pc.Communicate(pc.points[24], pc.points[78]);
        }
        public static void CreateTestTree(PointCommunications pc, int count)
        {
            pc.CreatePoints(count);
            /*
            pc.Communicate(pc.points[0], pc.points[1]);
            pc.Communicate(pc.points[1], pc.points[2]);
            pc.Communicate(pc.points[0], pc.points[9]);
            pc.Communicate(pc.points[0], pc.points[8]);
            pc.Communicate(pc.points[2], pc.points[5]);
            pc.Communicate(pc.points[5], pc.points[6]);
            pc.Communicate(pc.points[5], pc.points[3]);
            pc.Communicate(pc.points[2], pc.points[3]);
            pc.Communicate(pc.points[3], pc.points[4]);
            pc.Communicate(pc.points[2], pc.points[7]);
            */
            pc.Communicate(pc.points[0], pc.points[1]);
            pc.Communicate(pc.points[1], pc.points[4]);
            pc.Communicate(pc.points[4], pc.points[2]);
            pc.Communicate(pc.points[4], pc.points[3]);
            pc.Communicate(pc.points[4], pc.points[5]);
        }
        static void Main(string[] args)
        {
            PointCommunications PC = new PointCommunications();
            //CreateSapFloor(PC);
            CreateTestTree(PC, 6);

            Console.WriteLine(PC.GetWayAB(PC.points[0], PC.points[3]));

            

            Console.ReadKey();
        }
    }
}
