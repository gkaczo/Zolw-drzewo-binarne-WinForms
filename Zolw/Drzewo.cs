using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Zolw
{
    class Drzewo
    {
        public int stopien;
        public float rozmiar;
        private Pen pioro;

        public Bitmap bmp;

        zolw z;

        public Drzewo()
        {
            rozmiar = 0;
            pioro = new Pen(Color.Black);
            z = new zolw(200, 200);
        }

        public Drzewo(float nx, float ny, int st, float roz,int SizeX,int SizeY)
        {
            //  srand(time(NULL));
            //  kat=270;
            pioro = new Pen(Color.Black);
            z = new zolw(SizeX, SizeY);
            stopien = st;
            rozmiar = roz;
            z.Hop(0, -100);
        }

        public void Rysuj()
        {
            // podstawa drzewa
            z.Prawo(90);
            bmp=z.Naprzod(-3 * (float)rozmiar);
            bmp=z.Naprzod(7 * (float)rozmiar);
            bmp=z.Naprzod(-4 * (float)rozmiar);
            z.Lewo(90);
            bmp=z.Naprzod(60);


            /*     z.prawo(90);
                 z.naprzod(-60);
                 z.naprzod(140);
                 z.naprzod(-80);
                 z.lewo(90);
                 z.naprzod(120);*/


            Wyswietl(stopien, rozmiar, losKat());


        }
        private float losKat()
        {
            float rnd;

            Random r = new Random();
            rnd = (float)r.NextDouble() * 45;

            return rnd;
        }

        private int Wyswietl(int st, float roz, float kat)
        {

            if (st != 0)
            {

                z.Prawo(kat);
                bmp=z.Naprzod(roz);
                Wyswietl(st - 1, (float)(roz * 0.8), losKat());
                //powrot
                z.Prawo(180);
                bmp=z.Naprzod(roz);

                z.Prawo(180 - 2 * kat);
                bmp=z.Naprzod(roz);
                Wyswietl(st - 1, (float)(roz * 0.8), losKat());
                //   powrot
                z.Prawo(180);
                bmp=z.Naprzod(roz);
                z.Prawo(180 + kat);

            }
            else
            {
                return 0;
            }

            return 0;

        }
    }
}
