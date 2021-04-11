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
    public partial class frmEdytorNauczyciel : Form
    {
        ModelSzkolyContainer context = new ModelSzkolyContainer();
        czlowiekSet mojCzowiek;
        public frmEdytorNauczyciel(Int32 _Rekord)
        {
            InitializeComponent();
            switch (_Rekord)
            {
                case -1:
                    nowyRekord();
                    break;
                default:
                    edytujRekord(_Rekord);
                    break;
            }
        }
        /// <summary>
        /// Kod odpowiadający za stworzenie nowego rekordu w bazie danych nauczycieli
        /// </summary>
        private void nowyRekord()
        {
            mojCzowiek = new czlowiekSet();
        }

        private void edytujRekord(Int32 _Rekord)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mojCzowiek.Imie = imieTextBox.Text;
            mojCzowiek.Nazwisko = nazwiskoTextBox.Text;
            mojCzowiek.Wiek = (short)wiekNumericUpDown.Value;
            czlowiekSet_nauczyciel nauczyciel=new czlowiekSet_nauczyciel();
            nauczyciel.RokZatrudnienia=(short)rokZatrudnieniaNumericUpDown.Value;
            mojCzowiek.czlowiekSet_nauczyciel = nauczyciel;
            context.czlowiekSet.Add(mojCzowiek);
            context.SaveChanges();
            Close();
        }
    }
}
