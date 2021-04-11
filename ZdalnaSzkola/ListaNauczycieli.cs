using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZdalnaSzkola
{
    public partial class ListaNauczycieli : Form
    {
        ModelSzkolyContainer context = new ModelSzkolyContainer();
        public ListaNauczycieli()
        {
            InitializeComponent();
            pobieranieDanych();
        }

        private void pobieranieDanych()
        {
            
            var wynik = context.czlowiekSet_nauczyciel.Include("czlowiekSet").ToList();

            List<wyswietlanyNauczyciel> lista = new List<wyswietlanyNauczyciel>();
            foreach (var item in wynik)
            {
                wyswietlanyNauczyciel row = new wyswietlanyNauczyciel();
                row.Id = item.Id;
                row.Imie = item.czlowiekSet.Imie;
                row.Nazwisko = item.czlowiekSet.Nazwisko;
                row.Rok = item.RokZatrudnienia;
                row.Wiek = item.czlowiekSet.Wiek;
                lista.Add(row);
            }
            nauczycielDataGridView.DataSource = lista;
        }

        //            var zmienna = (
        //                from i in wynik
        //                select
        //(i.Id, i.czlowiekSet.Imie, i.czlowiekSet.Nazwisko, i.RokZatrudnienia, i.czlowiekSet.Wiek)).ToList();
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEdytorNauczyciel edytor = new frmEdytorNauczyciel(-1);
            edytor.ShowDialog();
            pobieranieDanych();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 mojId = (Int32)nauczycielDataGridView.CurrentRow.Cells[0].Value;
            //((czlowiekSet_nauczyciel)nauczycielBindingSource.Current).Id;
            // Int32 mojId = ((czlowiekSet_nauczyciel)nauczycielBindingSource.Current).Id;
            frmEdytorNauczyciel edytor = new frmEdytorNauczyciel(mojId);
            edytor.ShowDialog();
            pobieranieDanych();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć rekord?", ProductName, MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Int32 mojId = (Int32)nauczycielDataGridView.CurrentRow.Cells[0].Value;
                czlowiekSet wynik = context.czlowiekSet.Where(n => n.Id ==mojId).FirstOrDefault();
                context.czlowiekSet.Remove(wynik);
                context.SaveChanges();
                pobieranieDanych();
            }


        }
    }

    class wyswietlanyNauczyciel
    {
        public Int32 Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public short Rok { get; set; }
        public short Wiek { get; set; }

    }


}
