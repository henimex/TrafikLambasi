using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kg = 40, yg = 30;
        private void Form1_Load(object sender, EventArgs e)
        {
            label2kg.Parent = pictureBox1;
            label2kg.BackColor = Color.Transparent;
            label3yg.Parent = pictureBox1;
            label3yg.BackColor = Color.Transparent;
            timer1.Enabled = true;
            timer2.Enabled = true;
            //timer3.Enabled = true;
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer3.Interval = 1000;
            pictureBox2y.Visible = true;
            pictureBox3s.Visible = true;
            pictureBox4k.Visible = false;
            label2kg.Text = Convert.ToString(kg);
            label3yg.Text = Convert.ToString(yg);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int cd = Convert.ToInt32(label1.Text);
            cd++;
            label1.Text = cd.ToString();



            if (cd == 30)
            {
                pictureBox2y.Visible = true;
                pictureBox3s.Visible = false;
                pictureBox4k.Visible = false;
            }
            if (cd == 40)
            {
                pictureBox2y.Visible = false;
                pictureBox3s.Visible = true;
                pictureBox4k.Visible = true;
                kg = 40;
                timer2.Stop();
                timer3.Start();
            }
            if (cd == 70)
            {
                cd = 0;
                label1.Text = cd.ToString();
                pictureBox2y.Visible = true;
                pictureBox3s.Visible = true;
                pictureBox4k.Visible = false;
                timer2.Start();
                timer3.Stop();
                yg = 30;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kg--;
            label2kg.Text = kg.ToString().PadLeft(2, '0');
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            yg--;
            label3yg.Text = yg.ToString().PadLeft(2, '0');
        }

        private void pictureBox4k_Click(object sender, EventArgs e)
        {

        }
    }
}
