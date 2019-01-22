using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
//using System.Windows.Forms;

namespace Zolw
{
    class zolw
    {
        private Bitmap bmp;
        private Graphics graph;
        private Pen pioro;
        private float kat;
        private float rx;
        private float ry;
        private Point punkt = Point.Empty;

        public Color kolor{ get; set; }

        public zolw()  
        {
           
        }

        public zolw(int xSize, int ySize)
        {
            kolor = Color.Black;

            pioro = new Pen(kolor);

            bmp = new Bitmap(xSize, ySize);
            graph = Graphics.FromImage(bmp);

            punkt.X = xSize/2;
            punkt.Y = ySize/2;
            rx = (float)xSize / 2;
            ry = (float)ySize / 2;
            kat = 90;

        }

        public void Hop(float nx, float ny)
        {
            rx = rx + nx;
            ry = ry - ny;
            punkt.X = (int)rx;
            punkt.Y = (int)ry;
        }

        public Bitmap Naprzod(float n)
        {
            pioro = new Pen(kolor);

            rx = rx + n * (float)(Math.Cos(kat * Math.PI / 180));
            ry = ry - n * (float)(Math.Sin(kat * Math.PI / 180));
            graph.DrawLine(pioro, punkt.X, punkt.Y, rx, ry);

            punkt.X = (int)rx;
            punkt.Y = (int)ry;
            return bmp;

        }

        public void Prawo(float alfa)
        {
            kat = kat - alfa;
            while (kat >= 360) { kat = kat - 360; }
            while (kat < 0) { kat = kat + 360; }
        }

        public void Lewo(float alfa)
        {
            Prawo(-alfa);

        }


    }
}

