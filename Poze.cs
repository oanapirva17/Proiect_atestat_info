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

namespace Proiect_atestat_info
{
  
    namespace poze
    {
        public partial class Poze : Form
        {
            string[] lista_poze;
            int cnt , nr_poze;
            public Poze()
            {
                InitializeComponent();
                lista_poze = Directory.GetFiles(Directory.GetCurentDirectory() + @"Poze");
                nr_poze = lista_poze.Length;
                cnt = 0;
                poza.Load(lista_poze[cnt]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt > 0) cnt--;
            else cnt = 0;
            poza.Load(lista_poze[cnt]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt < nr_poze - 1) cnt++;
            else cnt = 0;
            poza.Load(lista_poze[cnt]);
        }

    }
}


