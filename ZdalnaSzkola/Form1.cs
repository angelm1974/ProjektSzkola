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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Azure;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            ListaNauczycieli ln = new ListaNauczycieli();
            ln.MdiParent = this; 
            ln.Show();
        }
    }
}
