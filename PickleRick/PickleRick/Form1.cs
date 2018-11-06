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
            Pen PDelg = new Pen(Color.Black, 1);


            #region Espejo
            e.Graphics.DrawLine(pnegro, 2,34, 185,26);
            e.Graphics.DrawLine(pnegro, 186, 26, 168, 185);
            e.Graphics.DrawLine(pnegro, 168, 185, 125, 189);
            e.Graphics.DrawLine(pnegro, 147, 210, 191, 208);
            e.Graphics.DrawLine(pnegro, 172, 190, 190, 22);
            e.Graphics.DrawLine(pnegro, 190, 19, 1, 26);
            e.Graphics.DrawLine(pnegro, 130, 192, 172, 190);
            e.Graphics.DrawLine(pnegro, 196, 217, 156, 217);
            e.Graphics.DrawLine(pnegro, 190, 210, 194, 215);
            e.Graphics.DrawLine(pnegro, 190, 208, 210, 4);
            e.Graphics.DrawLine(pnegro, 195, 214, 214, 12);
            e.Graphics.DrawLine(pnegro, 210, 5, 215, 11);
            e.Graphics.DrawLine(pnegro, 0, 12, 209, 4);
            #endregion

            #region cabeza
            e.Graphics.DrawBezier(pnegro, 393, 162, 402,138,407,130,434,126);
            e.Graphics.DrawBezier(pnegro, 434,126, 454, 131, 466, 136, 470, 158);
            e.Graphics.DrawBezier(pnegro, 393, 161, 392, 183, 392, 205, 393, 221);
            e.Graphics.DrawBezier(pnegro, 470, 159, 469, 174, 470, 194, 470, 211);
            e.Graphics.DrawBezier(pnegro, 469, 178,477 , 180, 478, 192, 471, 204);
            #endregion

            #region BrazoDerecho
            //Hombro
            e.Graphics.DrawLine(pnegro, 483, 210, 470, 211);
            e.Graphics.DrawLine(pnegro, 189, 24, 189, 30);
            e.Graphics.DrawLine(pnegro, 474, 248, 494, 242);
            e.Graphics.DrawBezier(pnegro, 485, 210, 497, 216, 499, 230, 496,242);

            //Brazo
            e.Graphics.DrawLine(pnegro, 486, 247, 512, 278);
            e.Graphics.DrawLine(pnegro, 476, 260, 506, 293);
            e.Graphics.DrawBezier(pnegro, 506, 287, 506, 293, 513,299,518, 297);
            e.Graphics.DrawLine(pnegro, 506, 287, 522,259);
            e.Graphics.DrawBezier(pnegro, 519, 296, 521, 288, 526, 277, 532, 264);

            #endregion

            #region Cuerpo
            e.Graphics.DrawLine(PDelg, 470, 212, 473, 231);
            e.Graphics.DrawLine(pnegro, 471, 242, 475, 270);


            #endregion
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
