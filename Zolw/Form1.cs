using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zolw
{
    public partial class Form1 : Form
    {

        Graphics graph;
        zolw z;

        public Form1()
        {
            InitializeComponent();
             z = new zolw(pctBox.Size.Width, pctBox.Size.Height);

        }

        private void btnNaprzod_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtKrok.Text);
            float kat = float.Parse(txtKat.Text);
            z.Prawo(kat);

            pctBox.Image = new Bitmap(z.Naprzod(n));
            graph = Graphics.FromImage(pctBox.Image);
            pctBox.Refresh();

        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            Color kolor = new Color();

            if(DialogResult.OK == colorDlg.ShowDialog())
            {
                kolor = colorDlg.Color;
                lblColor.BackColor = kolor;
                z.kolor = kolor;
            }
        }

        private void btnRysujDrzewo_Click(object sender, EventArgs e)
        {
            Drzewo d = new Drzewo(0, 0, 8, 30, pctBox.Size.Width, pctBox.Size.Height);
            d.Rysuj();
            pctBox.Image = new Bitmap(d.bmp);
            graph = Graphics.FromImage(pctBox.Image);
            pctBox.Refresh();
        }
    }
}
