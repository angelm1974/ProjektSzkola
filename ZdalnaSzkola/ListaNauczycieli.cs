using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZdalnaSzkola
{
    public partial class ListaNauczycieli : Form
    {
        public ListaNauczycieli()
        {
            InitializeComponent();
            ModelSzkolyContainer context = new ModelSzkolyContainer();
            var wynik= context.czlowiekSet_nauczyciel.Include("czlowiekSet").ToList();
            nauczycielBindingSource.DataSource = wynik;
            
            foreach (var item in wynik)
            {
                MessageBox.Show(item.czlowiekSet.Imie +" " + item.czlowiekSet.Nazwisko);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
