using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Terem
    {
        string nev;
        Image nevadokep;
        int sorok;
        int szekek;
        char[,] ulesek;

        public string Nev { get => nev; set => nev = value; }
        public Image Nevadokep { get => nevadokep; set => nevadokep = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public char[,] Ulesek { get => ulesek; set => ulesek = value; }

        public Terem(string nev, int sorok, int szekek, char[,] ulesek, Image nevadokep)
        {
            this.nev = nev;
            this.sorok = sorok;
            this.szekek = szekek;
            this.ulesek = ulesek;
            this.nevadokep = nevadokep;
        }
    }
}
