using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectionsAB.Models;
using static DirectionsAB.PointCommunications;

namespace DirectionsAB
{
    public partial class Form1 : Form
    {
        System.Drawing.Point start, finish;
        Graphics gpu;
        public static float coef;
        RutWayBuilder builder;
        Director director;
        Form2 commForm;
        MapContext context = new MapContext();
        MapContext context2 = new MapContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            coef = 1920 / map.Width;
            while (coef<(double)1920 / map.Width)
            {
                coef += 0.001f;
            }
            foreach(DirectionsAB.Models.Region r in context.Regions)
            {
                points.Add((Point)r);
                gpu.DrawRectangle(new Pen(Color.Blue, 3),
                                  points.Last().X1*coef,
                                  points.Last().Y1*coef,
                                  (points.Last().X2 - points.Last().X1)*coef,
                                  (points.Last().Y2 - points.Last().Y1)*coef);
                PointF p = new PointF(points.Last().X-6, points.Last().Y-6);
                gpu.DrawString(points.Last().Name, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, p);
            }
            foreach (Point p in points)
            {
                IEnumerable<DirectionsAB.Models.Communication> communications = context.Communications.Where(c => c.RegionID == p.RegionId);
                foreach (DirectionsAB.Models.Communication communication in communications)
                {
                    if(p.coef_comm==null)
                        p.coef_comm = new List<int>();
                    p.coef_comm.Add(communication.CommID);
                }
            }
            DrawCommunications(Color.Green, 2);
        }
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
                if (start.X >= points[i].X1 && start.X <= points[i].X2 &&
                    start.Y >= points[i].Y1 && start.Y <= points[i].Y2)
                {
                    indP1 = i;
                }
                else if (finish.X >= points[i].X1 && finish.X <= points[i].X2 &&
                    finish.Y >= points[i].Y1 && finish.Y <= points[i].Y2)
                {
                    indP2 = i;
                }
            }
            if (points.Count != 0)
            {
                director.Construct(points[indP1], points[indP2]);
                for (int i = 0; i < builder.resultWay.resultPoints.Count - 1; i++)
                {
                    gpu.DrawLine(new Pen(color, width),
                                   builder.resultWay.resultPoints[i].X,
                                   builder.resultWay.resultPoints[i].Y,
                                   builder.resultWay.resultPoints[i + 1].X,
                                   builder.resultWay.resultPoints[i + 1].Y);
                }
                builder.wayA.Clear();
                builder.wayB.Clear();
                builder.fork.Clear();
                builder.resultWay.resultPoints.Clear();
            }
            else
                MessageBox.Show("Невозможно построить маршрут!\nНе существует активных областей.");
        }

        //Отрисовка связей между областями (узлами графа путей)
        public void DrawCommunications(Color color, int width) 
        {
            int count=0;
            List<DirectionsAB.Point> p1p2 = new List<DirectionsAB.Point>();
            foreach (Communication c in context.Communications)
            {
                p1p2.Add(points.FirstOrDefault(p => p.RegionId == c.RegionID));
                if (count == 1)
                {
                    gpu.DrawLine(new Pen(color, width),
                    p1p2[0].X,
                    p1p2[0].Y,
                    p1p2[1].X,
                    p1p2[1].Y);
                    PointF p_text = new PointF();
                    float lengthX = Math.Abs(p1p2[0].X - p1p2[1].X);
                    float lengthY = Math.Abs(p1p2[0].Y - p1p2[1].Y);
                    p_text.X = p1p2[0].X >= p1p2[1].X ? (p1p2[1].X + lengthX/2) : (p1p2[0].X + lengthX/2);
                    p_text.Y = p1p2[0].Y >= p1p2[1].Y ? (p1p2[1].Y + lengthY/2) : (p1p2[0].Y + lengthY/2);
                    gpu.DrawEllipse(new Pen(Color.Red, width), new RectangleF(p_text, new SizeF(3, 3)));
                    gpu.DrawString(c.CommID.ToString(), new Font("Times New Roman", 12), Brushes.Red, p_text);
                    count = 0;
                    p1p2.Clear();
                }
                else
                    count++;
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
                PointF p = new PointF(points.Last().X*coef - 6, points.Last().Y*coef - 6);
                gpu.DrawString(points.Last().Name, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, p);
                listBox1.Items.Add($"Область {points.Count - 1}, " +
                    $"координаты ({points[points.Count - 1].X} , {points[points.Count - 1].Y})");
            }
            else
                MessageBox.Show("Ошибка в создании активной области-точки");
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (start.IsEmpty||(start.X==0&&start.Y==0))
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
                    if (e.X >= points[i].X1 && e.X <= points[i].X2 &&
                        e.Y >= points[i].Y1 && e.Y <= points[i].Y2)
                    {
                        point_name.Text = Convert.ToString(points[i].Name);
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

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i=0;i<points.Count;i++)
                listBox1.Items.Add($"Область {i}, " +
                   $"координаты ({points[i].X} , {points[i].Y})");
        }

        private void button4_Click(object sender, EventArgs e)//обновляет карту полностью
        {
            map.Image = Properties.Resources.firstfloor_land;
            gpu = Graphics.FromImage(map.Image);
            map.Invalidate();
            foreach (Point p in points)
            {
                gpu.DrawRectangle(new Pen(Color.Blue, 3),
                                  p.X1 * coef,
                                  p.Y1 * coef,
                                  (p.X2 - p.X1) * coef,
                                  (p.Y2 - p.Y1) * coef);
            }
            DrawCommunications(Color.Green, 3);
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
