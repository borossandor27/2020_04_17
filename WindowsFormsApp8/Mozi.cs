using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp8
{
    class Mozi
    {
        public List<Terem> termek = new List<Terem>();
        public void Mentes()
        {

        }

        public Mozi(string forras)
        {
            try
            {
                using (StreamReader sr = new StreamReader(forras))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int sorokSzama = int.Parse(sor[0]);
                        int szekekSzama = int.Parse(sor[1]);
                        char[,] ulesek = new char[sorokSzama, szekekSzama];
                        string line = "";
                        while (!string.IsNullOrEmpty((line = sr.ReadLine())))
                        {
                            sor = line.Split(';');
                            ulesek[int.Parse(sor[0]) - 1, int.Parse(sor[1]) - 1] = sor[2][0];
                        }
                        Image nevadoKep = Image.FromFile(nev.Split()[0] + ".jpg");
                        termek.Add(new Terem(nev, sorokSzama, szekekSzama, ulesek, nevadoKep));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message+"\n\nA program leáll");
                Environment.Exit(0);
            }
        }
    }
}
