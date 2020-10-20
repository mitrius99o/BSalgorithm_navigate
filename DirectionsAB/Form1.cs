using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectionsAB
{
    public partial class Form1 : Form
    {
        System.Drawing.Point start, finish;
        Graphics gpu;
        const float coef = 2.36f;
        public Form1()
        {
            InitializeComponent();
            gpu = Graphics.FromImage(map.Image);
        }
        public void DrawPath(Color color, int width)
        {
            gpu.DrawLine(new Pen(color, width),
                           start.X * coef,
                           start.Y * coef,
                           finish.X * coef,
                           finish.Y * coef);
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            //Color[] colors = new Color[] { Color.Red,
            ///                     Color.Blue, Color.Yellow,
            //                     Color.Green, Color.Black,
            //                     Color.HotPink };
            //int rnmColorNum = new Random().Next(0, colors.Length - 1);
            
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
                /*if (tabControl1.SelectedTab == tabPage3) CreatePoint();
                else */DrawPath(Color.Red, 10);
                map.Invalidate();
                start.X = 0;
                start.Y = 0;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
