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
    public partial class Form3 : Form
    {
        MapContext context = new MapContext();
        Form1 formPrev;

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form1 f)
        {
            formPrev = f;
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (DirectionsAB.Models.Region region in context.Regions)
                comboBox1.Items.Add(region.Name);
           // if(Form1)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Вывод информации о выбранной области 
            textBox1.Text = context.Regions.ToList()[comboBox1.SelectedIndex].Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.Regions.ToList()[comboBox1.SelectedIndex].Name = textBox1.Text;
            context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.Regions.ToList()[comboBox1.SelectedIndex].Name = textBox1.Text;
            context.SaveChanges();
            //-------------------------
            formPrev.map.Image = Properties.Resources.seventhfloor_land;
            formPrev.Gpu = Graphics.FromImage(formPrev.map.Image);
            formPrev.map.Invalidate();
            foreach (Point p in context.Regions)
            {
                formPrev.Gpu.DrawRectangle(new Pen(Color.Blue, 3),
                                  p.X1 * Form1.coef,
                                  p.Y1 * Form1.coef,
                                  (p.X2 - p.X1) * Form1.coef,
                                  (p.Y2 - p.Y1) * Form1.coef);
                PointF p_ = new PointF(p.X - 6, p.Y - 6);
                formPrev.Gpu.DrawString(p.Name, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, p_);
            }
            formPrev.DrawCommunications(Color.Green, 2);
            //-----------------
            this.Close();
        }
    }
}
