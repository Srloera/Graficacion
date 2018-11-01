using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickleRick
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
           
        }


        Point sp = new Point(0, 0);
        int cX, cY, x, y, dX, dY;
        int k = 0;
        Point ep = new Point(0, 0);

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "X= " + e.X + "Y= " + e.Y;
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        
                sp = e.Location;
                if (e.Button == MouseButtons.Left)
                {
                    k = 1;
                }
                cX = e.X;
                cY = e.Y;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelx.Text = "X: " + Convert.ToString(x);
            labely.Text = "y: " + Convert.ToString(y);
            if (k == 1)
            {
                ep = e.Location;
                x = e.X;
                y = e.Y;
            }
            sp = ep;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                x = e.X;
                y = e.Y;
                dX = e.X - cX;
                dY = e.Y - cY;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pnegro = new Pen(Color.Black, 2);


           e.Graphics.DrawBezier(pnegro, 0,34, 0,34,188,28,189,29);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void PictureboxBack_MouseUp(object sender, MouseEventArgs e)
        {
 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelx_Click(object sender, EventArgs e)
        {

        }
    }
}
