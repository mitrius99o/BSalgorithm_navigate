using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DirectionsAB.PointCommunications;

namespace DirectionsAB
{
    public partial class Form1 : Form
    {
        System.Drawing.Point start, finish;
        Graphics gpu;
        const float coef = 2.36f;
        RutWayBuilder builder;
        Director director;
        Form2 commForm;
        public Form1()
        {
            InitializeComponent();
            gpu = Graphics.FromImage(map.Image);

            builder = new RutWayBuilder();
            director = new Director(builder);
        }
        public bool FindIndexes(out int ind1, out int ind2)
        {
            ind1 = 0;
            ind2 = 0;
            int count = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (start.X >= points[i].p1.X && start.X <= points[i].p2.X &&
                    start.Y >= points[i].p1.Y && start.Y <= points[i].p2.Y)
                {
                    count++;
                    ind1 = i;
                }
                else if (finish.X >= points[i].p1.X && finish.X <= points[i].p2.X &&
                    finish.Y >= points[i].p1.Y && finish.Y <= points[i].p2.Y)
                {
                    count++;
                    ind2 = i;
                }
                else
                    return false;
            }
            return (count == 2) ? true : false;
        }
        public void DrawPath(Color color, int width)
        {
            int indP1=0, indP2=0;
            for (int i = 0; i < points.Count; i++)
            {
                if (start.X >= points[i].p1.X && start.X <= points[i].p2.X &&
                    start.Y >= points[i].p1.Y && start.Y <= points[i].p2.Y)
                {
                    indP1 = i;
                }
                else if (finish.X >= points[i].p1.X && finish.X <= points[i].p2.X &&
                    finish.Y >= points[i].p1.Y && finish.Y <= points[i].p2.Y)
                {
                    indP2 = i;
                }
            }
            director.Construct(points[indP1], points[indP2]);
            for (int i = 0; i < builder.resultWay.resultPoints.Count - 1; i++)
            {
                gpu.DrawLine(new Pen(color, width),
                               builder.resultWay.resultPoints[i].X,
                               builder.resultWay.resultPoints[i].Y,
                               builder.resultWay.resultPoints[i + 1].X,
                               builder.resultWay.resultPoints[i + 1].Y);
            }
        }
        public void DrawAddPoint()
        {
            if (CreatePoint(start, finish))
            {
                gpu.DrawRectangle(new Pen(Color.Blue, 3),
                                  start.X * coef,
                                  start.Y * coef,
                                  (finish.X - start.X) * coef,
                                  (finish.Y - start.Y) * coef);
                listBox1.Items.Add($"Область {points.IndexOf(points[points.Count - 1])}, " +
                    $"координаты ({points[points.Count - 1].X} , {points[points.Count - 1].Y})");
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (start.IsEmpty)
            {   
                start.X = e.X;
                start.Y = e.Y;
                finish.X = 0;
                finish.Y = 0;
            }
            else
            {
                finish.X = e.X;
                finish.Y = e.Y;
                if (tabControl1.SelectedTab == tabPage3)
                    DrawAddPoint();
                else if (tabControl1.SelectedTab == tabPage2)
                { }
                else
                {
                    DrawPath(Color.Red, 10); 
                }
                map.Invalidate();
                start.X = 0;
                start.Y = 0;
            }
        }
        

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
                for (int i = 0; i < points.Count; i++)
                {
                    if (e.X >= points[i].p1.X && e.X <= points[i].p2.X &&
                        e.Y >= points[i].p1.Y && e.Y <= points[i].p2.Y)
                    {
                        point_name.Text = Convert.ToString(points[i].name);
                        label15.Text = Convert.ToString(points[i].X);
                        label16.Text = Convert.ToString(points[i].Y);
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            commForm = new Form2();
            commForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
