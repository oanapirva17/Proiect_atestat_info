using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_atestat_info
{
    public partial class Poze : Form
    {
        public Poze()
        {
            InitializeComponent();
        }
    namespace poze
    {
        public partial class Poze : Form
        {
            String lista_poze;
            int crt, nr_poze;
            public Poze()
            {
                InitializeComponent();
                lista_poze = Directory.GetFiles(Directory.GetCurentDirectory() + @"poze");
                lista_poze = lista_poze.Length;
                crt = 0;
                poza.Load(lista_poze[crt]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (crt > 0) crt--;
            else crt = 0;
            poza.Load(lista_poze[crt]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crt < nr_poze - 1) crt++;
            else crt = 0;
            poza.Load(lista_poze[crt]);
        }
    }
}
