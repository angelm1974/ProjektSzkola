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
        Int32 _Rekord;
        public frmEdytorNauczyciel(Int32 _rekord)
        {
            InitializeComponent();
            _Rekord = _rekord;
            switch (_Rekord)
            {
                case -1:
                    nowyRekord();
                    break;
                default:
                    edytujRekord();
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

        private void edytujRekord()
        {
            var wynik = context.czlowiekSet_nauczyciel.Include("czlowiekSet").Where(n => n.Id == _Rekord).FirstOrDefault();
            czlowiekSet_nauczycielBindingSource.DataSource = wynik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_Rekord)
            {
                case -1:
                    mojCzowiek.Imie = imieTextBox.Text;
                    mojCzowiek.Nazwisko = nazwiskoTextBox.Text;
                    mojCzowiek.Wiek = (short)wiekNumericUpDown.Value;
                    czlowiekSet_nauczyciel nauczyciel = new czlowiekSet_nauczyciel();
                    nauczyciel.RokZatrudnienia = (short)rokZatrudnieniaNumericUpDown.Value;
                    mojCzowiek.czlowiekSet_nauczyciel = nauczyciel;
                    context.czlowiekSet.Add(mojCzowiek);
                    break;
                default:

                    break;
            }
            context.SaveChanges();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
