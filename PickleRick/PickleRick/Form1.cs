using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

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
            labelx1.Text = "X: " + Convert.ToString(x);
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

            //g.FillPie(mySolidBrush, 393, 164, 433, 126,48,15 );
            //myGraphics.DrawArc(myPen, 0, 0, 140, 70, 0, 120);
            //LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(myRectangle,Color.Blue,Color.Green,LinearGradientMode.Horizontal);
            //myGraphics.FillEllipse(myLinearGradientBrush, myRectangle);

            //g.FillClosedCurve(mySolidBrush, myPointArray);

            SolidBrush ColorNegro = new SolidBrush(Color.Black);
            SolidBrush ColorHuesos = new SolidBrush(Color.Gray);
            SolidBrush ColorMuñecaSuperiorIzquierda = new SolidBrush(Color.Orange);
            SolidBrush ColorMuñecaInferiorIzquierda1 = new SolidBrush(Color.DimGray);
            SolidBrush ColorMuñecaInferiorIzquierda2 = new SolidBrush(Color.Gray);
            Pen pnegro = new Pen(Color.Black, 2);
            Pen PDelg = new Pen(Color.Black, 1);
            Pen PGrue = new Pen(Color.Black, 3);
            Pen PVerde = new Pen(Color.Green, 2);
            Pen PHuesoEse = new Pen(Color.Black, 4);
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;




            #region Espejo
            e.Graphics.DrawLine(pnegro, 2, 34, 185, 26);
            e.Graphics.DrawLine(pnegro, 186, 26, 168, 185);
            e.Graphics.DrawLine(pnegro, 168, 185, 125, 189);
            e.Graphics.DrawLine(pnegro, 147, 210, 191, 208);
            e.Graphics.DrawLine(pnegro, 172, 190, 190, 22);
            e.Graphics.DrawLine(pnegro, 189, 19, 1, 26);
            e.Graphics.DrawLine(pnegro, 130, 192, 172, 190);
            e.Graphics.DrawLine(pnegro, 196, 217, 156, 217);
            e.Graphics.DrawLine(pnegro, 190, 210, 194, 215);
            e.Graphics.DrawLine(pnegro, 190, 208, 210, 4);
            e.Graphics.DrawLine(pnegro, 195, 214, 214, 10);
            e.Graphics.DrawLine(pnegro, 210, 5, 215, 11);
            e.Graphics.DrawLine(pnegro, 0, 12, 209, 4);
            g.DrawLine(pnegro, 190, 19, 190, 32);
            #endregion

            #region cabeza
            //Point[] myPointArray ={p1, new Point(402, 138), new Point(407, 130), new Point(434, 126) };
            //Point[] myPointArray1 ={new Point(0, 0), new Point(60, 20), new Point(40, 50) };
            //g.DrawClosedCurve(pnegro, myPointArray1);

            //g.DrawPolygon(pnegro, myPointArray);
            e.Graphics.DrawBezier(pnegro, 393, 162, 402,138,407,130,434,126);
            e.Graphics.DrawBezier(pnegro, 434,126, 454, 131, 466, 136, 470, 158);
            e.Graphics.DrawBezier(pnegro, 393, 161, 392, 183, 392, 205, 393, 221);
            e.Graphics.DrawBezier(pnegro, 469, 158, 469, 174, 470, 194, 470, 211);
            e.Graphics.DrawBezier(pnegro, 469, 178,477 , 180, 478, 192, 471, 204);
            #endregion

            #region BrazoIzquierdo
            //Hombro
            Point[] HombroIzquierdo =
                {
                new Point(399, 252),
                new Point(404, 238),
                new Point(402, 227),
                new Point(400, 225),
                new Point(389,220),
                new Point(373, 222),
                new Point(365, 231),
                new Point(357, 239),
                new Point(356, 245),
                new Point(358,267),
                new Point(362, 254),
                new Point(362, 265),
                new Point(366, 261),
                new Point(364, 267),
                new Point(369, 262),
                new Point(370, 263),
                new Point(377, 262),
                new Point(392, 253),
                new Point(398, 247)};

            //Brazo
            Point[] BrazoSuperior =
                {
                new Point(354, 255),
                new Point(353, 262),
                new Point(347, 274),
                new Point(340, 299),
                new Point(342, 302),
                new Point(351, 302),
                new Point(362, 292),
                new Point(371, 283),
                new Point(380, 271),
                new Point(390, 258)};

            Point[] BrazoInferior =
                {
                new Point(341, 291),
                new Point(334, 292),
                new Point(332, 298),
                new Point(333, 307),
                new Point(329, 315),
                new Point(328, 328),
                new Point(326, 338),
                new Point(334, 340),
                new Point(338, 333),
                new Point(339, 325),
                new Point(345, 313),
                new Point(354, 307),
                new Point(354, 302),
                new Point(342, 303),
                new Point(339, 300)};
            #endregion

            #region BrazoDerecho
            //Hombro
            e.Graphics.DrawLine(pnegro, 486, 210, 470, 211);
            e.Graphics.DrawLine(pnegro, 189, 24, 189, 30);
            e.Graphics.DrawLine(pnegro, 474, 258, 497, 241);
            e.Graphics.DrawBezier(pnegro, 485, 210, 497, 216, 499, 230, 496,242);

            //Brazo
            e.Graphics.DrawLine(pnegro, 486, 247, 512, 278);
            e.Graphics.DrawLine(pnegro, 474, 258, 506, 293);
            e.Graphics.DrawBezier(pnegro, 506, 287, 498, 298, 523, 299,528, 291);
            e.Graphics.DrawLine(pnegro, 506, 287, 523,257);
            e.Graphics.DrawBezier(pnegro, 519, 296, 521, 288, 526, 277, 532, 264);
            e.Graphics.DrawBezier(pnegro, 528, 292, 527, 285, 528, 276, 533, 262);
            #endregion

            #region ManoDerecha
            //new Point p2 =new Point ()
            e.Graphics.DrawBezier(pnegro, 519, 248, 522,261, 533, 264, 538, 262);
            e.Graphics.DrawLine(pnegro, 519, 248, 532, 217);
            e.Graphics.DrawLine(pnegro, 539, 262, 558, 251);
            e.Graphics.DrawLine(pnegro, 539, 262, 548, 229);
            e.Graphics.DrawBezier(pnegro, 534, 208,528, 218, 534, 226, 546, 229);
            e.Graphics.DrawLine(pnegro, 547, 228, 565, 218);
            e.Graphics.DrawLine(pnegro, 565, 218, 559, 212);
            e.Graphics.DrawLine(pnegro, 556, 252, 559, 242);
            e.Graphics.DrawBezier(pnegro, 559, 213, 554, 223, 534, 214, 531, 198);
            g.DrawRectangle(pnegro, 555, 228, 10, 15);
            e.Graphics.DrawLine(pnegro, 563, 218, 562, 228);
            e.Graphics.DrawLine(pnegro, 574, 205, 565, 228);
            e.Graphics.DrawLine(pnegro, 565, 242, 572, 242);
            e.Graphics.DrawLine(pnegro, 574, 206, 606, 193);
            e.Graphics.DrawLine(pnegro, 606, 193, 602, 204);
            e.Graphics.DrawLine(pnegro, 606, 193, 588, 174);
            e.Graphics.DrawLine(pnegro, 574, 207, 568, 199);
            e.Graphics.DrawLine(pnegro, 547, 179, 563, 172);
            e.Graphics.DrawLine(pnegro, 559, 215, 571, 194);
            g.DrawBezier(pnegro, 531, 199, 534, 192, 535, 189, 534, 184);
            g.DrawBezier(pnegro, 571, 242, 570, 230, 587, 206, 602, 203);
            g.DrawBezier(pnegro, 571, 242, 587, 244, 610, 214, 602, 204);

            #endregion

            #region ManoIzquierda
            Point[] MuñecaSuperiorIzquierda =
                {
                new Point(338, 334),
                new Point(343, 339),
                new Point(341, 345),
                new Point(339, 356),
                new Point(331, 361),
                new Point(323, 353),
                new Point(324, 347),
                new Point(322, 339),
                new Point(327, 331)};
            Point[] MuñecaInferiorIzquierda1 =
                {
                new Point(346, 347),
                new Point(318, 347),
                new Point(317, 371),
                new Point(330, 387),
                new Point(346, 376)};
            Point[] MuñecaInferiorIzquierda2 =
                {
                new Point(342, 344),
                new Point(348, 357),
                new Point(347, 366),
                new Point(346, 376),
                new Point(342, 383),
                new Point(330, 387),
                new Point(330, 365),
                new Point(339, 362),
                new Point(343, 356)};
            Point[] ManoIzquierda =
                {
                new Point(323, 384),
                new Point(321, 398),
                new Point(324, 400),
                new Point(326, 396),
                new Point(325, 404),
                new Point(329, 406),
                new Point(330, 403),
                new Point(334, 410),
                new Point(342, 407),
                new Point(342, 411),
                new Point(346, 413),
                new Point(349, 403),
                new Point(348, 390),
                new Point(344, 384)};

            #endregion

            #region PiernaIzquierda
            Point[] MusloIzquierdo =
                {
                new Point(410, 399),
                new Point(406, 387),
                new Point(396, 384),
                new Point(382, 394),
                new Point(379, 410),
                new Point(382, 422),
                new Point(385, 438),
                new Point(387, 448),
                new Point(386, 457),
                new Point(395, 463),
                new Point(399, 462),
                new Point(406, 457),
                new Point(406, 433),
                new Point(409, 398)};

            Point[] HuesoMulsoIzquierdo1 =
                {
                new Point(413, 395),
                new Point(390, 402)};

            Point[] HuesoMusloIzquierdo2 =
                {
                new Point(397, 398),
                new Point(394, 395),
                new Point(391, 398),
                new Point(393, 399),
                new Point(394, 402),
                new Point(392, 403),
                new Point(389, 458),
                new Point(394, 459),
                new Point(397, 402),
                new Point(398, 398)};

            Point[] RodillaIzquierda1 =
                {
                new Point(394, 465),
                new Point(403, 460),
                new Point(409, 465),
                new Point(409, 468),
                new Point(394, 473),
                new Point(393, 467)};

            #endregion

            #region Cuerpo
            g.DrawLine(PDelg, 470, 212, 473, 231);
            g.DrawLine(pnegro, 471, 242, 475, 270);
            g.DrawLine(pnegro, 476, 278, 476, 289);
            g.DrawLine(PDelg, 477, 294, 478, 308);
            g.DrawLine(pnegro, 394, 254, 394, 268);
            g.DrawLine(pnegro, 394, 278, 392, 290);
            g.DrawLine(pnegro, 392, 298, 392, 310);
            Point[] Cuerpo =
                {
                new Point(393, 222),
                new Point(393, 165),
                new Point(406, 138),
                new Point(434, 126),
                new Point(460, 137),
                new Point(470, 155),
                new Point(470, 182),
                new Point(470, 202),
                new Point(473, 230),
                new Point(474, 270),
                new Point(478, 322),
                new Point(478, 334),
                new Point(469, 378),
                new Point(460, 400),
                new Point(450, 409),
                new Point(446, 410),
                new Point(419, 405),
                new Point(401, 390),
                new Point(391, 381),
                new Point(391, 346),
                new Point(394, 221)};

            Point[] MadreEsa1 =
                {
                new Point(479, 350),
                new Point(474, 371),
                new Point(464, 399),
                new Point(440, 414),
                new Point(422, 409),
                new Point(419, 405)};
            Point[] MadreEsa2 =
                {
                new Point(428, 411),
                new Point(425, 403),
                new Point(422, 392),
                new Point(419, 372),
                new Point(412, 358),
                new Point(403, 354),
                new Point(391, 346),               
                new Point(386, 345),
                new Point(389, 353),
                new Point(396, 361),
                new Point(408, 367),
                new Point(414, 377),
                new Point(414, 381),
                new Point(416, 396),
                new Point(410, 399),
                new Point(420, 410)};


            #endregion

            #region Huesos
            //HuesosDerecha//
            g.DrawBezier(PDelg, 464, 245, 474, 239, 478, 233, 474, 228);
            g.DrawBezier(PDelg, 464, 244, 470, 237, 473, 230, 473, 230);
            g.DrawBezier(PDelg, 466, 281, 475, 274, 476, 270, 476, 270);
            g.DrawBezier(PDelg, 466, 281, 477, 278, 480, 273, 477, 266);
            g.DrawBezier(PDelg, 466, 296, 466, 296, 478, 288, 478, 288);
            g.DrawBezier(PDelg, 466, 296, 477, 294, 481, 290, 477, 286);
            g.DrawBezier(PDelg, 466, 314, 474, 310, 478, 307, 478, 307);
            g.DrawBezier(PDelg, 466, 314, 478, 313, 482, 310, 477, 305);

            Point[] HuesoIzquierda0 =
                {
                new Point(402, 234),
                new Point(412, 242),
                new Point(427, 248),
                new Point(413, 248),
                new Point(401, 245),
                new Point(398, 242),
                new Point(401, 236) };
            Point[] HuesoIzquierda1 =
                {
                new Point(393, 267),
                new Point(407,280),
                new Point(437, 286),
                new Point(412, 288),
                new Point(388,272),
                new Point(393, 262) };
            Point[] HuesoIzquierda2 =
                {
                new Point(392, 287),
                new Point(397, 297),
                new Point(409, 303),
                new Point(436, 302),
                new Point(407, 308),
                new Point(387, 290),
                new Point(393, 280) };

            Point[] HuesoIzquierda3 =
                {
                new Point(391, 310),
                new Point(405, 320),
                new Point(434, 319),
                new Point(411, 326),
                new Point(390, 318),
                new Point(388, 311),
                new Point(391, 302)};
            #endregion

            #region mueble
            e.Graphics.DrawLine(pnegro, 0, 146, 77, 144);
            e.Graphics.DrawLine(pnegro, 1, 150, 75, 148);
            e.Graphics.DrawLine(pnegro, 77, 144, 75, 163);
            e.Graphics.DrawLine(pnegro, 74, 163, 2, 165);
            e.Graphics.DrawLine(pnegro, 76, 144, 199, 258);
            e.Graphics.DrawLine(pnegro, 78, 150, 198, 259);
            e.Graphics.DrawLine(pnegro, 77, 164, 197,268);
            e.Graphics.DrawLine(pnegro, 71, 166, 190, 271);
            e.Graphics.DrawLine(pnegro, 197, 269, 190, 270);
            e.Graphics.DrawLine(pnegro, 196, 259, 196, 266);
            e.Graphics.DrawLine(pnegro, 70, 163, 46, 418);
            e.Graphics.DrawLine(pnegro, 45, 163, 17, 418);
            e.Graphics.DrawLine(pnegro, 54, 419, 1, 418);
            e.Graphics.DrawLine(pnegro, 54, 418, 48, 473);


            #endregion

            #region Metodos
            //CuerpoContorno//
            g.DrawClosedCurve(PVerde, Cuerpo);
            

            //HombroIzquierdo//
            g.DrawClosedCurve(pnegro, HombroIzquierdo);

            //Brazos//
            g.DrawPolygon(pnegro, BrazoSuperior);
            g.DrawPolygon(pnegro, BrazoInferior);

            //Manos//
            g.DrawClosedCurve(pnegro, ManoIzquierda);
            g.DrawClosedCurve(pnegro, MuñecaInferiorIzquierda1);
            //g.FillClosedCurve(ColorMuñecaInferiorIzquierda1, MuñecaInferiorIzquierda1);
            g.DrawClosedCurve(pnegro, MuñecaInferiorIzquierda2);
            //g.FillClosedCurve(ColorMuñecaInferiorIzquierda2, MuñecaInferiorIzquierda2);
            g.DrawClosedCurve(pnegro, MuñecaSuperiorIzquierda);
            //g.FillClosedCurve(ColorMuñecaSuperiorIzquierda, MuñecaSuperiorIzquierda);

            //Huesos//
            g.DrawClosedCurve(PDelg, HuesoIzquierda0);
            g.DrawClosedCurve(PDelg, HuesoIzquierda1);
            g.FillClosedCurve(ColorHuesos, HuesoIzquierda1);
            g.DrawClosedCurve(PDelg, HuesoIzquierda2);
            g.DrawClosedCurve(PDelg, HuesoIzquierda3);

            //MadreEsa//
            g.DrawClosedCurve(pnegro, MadreEsa2);
            //g.FillClosedCurve(ColorNegro, MadreEsa2);
            g.DrawCurve(PHuesoEse, MadreEsa1);

            //Piernas//
            g.DrawClosedCurve(pnegro, MusloIzquierdo);
            g.DrawLines(PGrue, HuesoMulsoIzquierdo1);
            g.DrawClosedCurve(pnegro, HuesoMusloIzquierdo2);
            g.DrawClosedCurve(PDelg, RodillaIzquierda1);
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
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
