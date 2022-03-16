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

        public Form3()
        {
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
        
    }
}
