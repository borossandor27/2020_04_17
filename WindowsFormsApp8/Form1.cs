using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Mozi Corvin = new Mozi("CorvinMozi.csv");
        int meret = 30;
        int aktTerem = 0;
        Image[] szekKep = new Image[] { Image.FromFile("ures.png"), Image.FromFile("gyerek.png"), Image.FromFile("felnott.png") };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Terem_update();
        }

        void Terem_update()
        {
            panel_Terem.Controls.Clear();
            this.Text = Corvin.termek[aktTerem].Nev + " terem";
            pictureBox_Nevado.Image = Corvin.termek[aktTerem].Nevadokep;
            pictureBox_Nevado.SizeMode = PictureBoxSizeMode.Zoom;
            for (int i = 0; i < Corvin.termek[aktTerem].Sorok; i++)
            {
                for (int j = 0; j < Corvin.termek[aktTerem].Szekek; j++)
                {
                    PictureBox szek = new PictureBox();
                    szek.SetBounds(j * meret, i * meret, meret, meret);
                    szek.SizeMode = PictureBoxSizeMode.StretchImage;
                    szek.Padding = new Padding(3);
                    switch (Corvin.termek[aktTerem].Ulesek[i,j])
                    {
                        case 'F':
                            szek.Image = szekKep[2];
                            break;
                        case 'D':
                            szek.Image = szekKep[1];
                            break;
                        case '\0':
                            szek.Image = szekKep[0];
                            break;
                        default:
                            break;
                    }
                    panel_Terem.Controls.Add(szek);
                }
            }
        }
    }
}
