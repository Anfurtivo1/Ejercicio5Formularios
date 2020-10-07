using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mcCalendario1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            dtpCalendario2.Value = mcCalendario1.SelectionStart;
            txaFecha.Text = Convert.ToString(dtpCalendario2.Value);
        }

        private void dtpCalendario2_ValueChanged(object sender, EventArgs e)
        {
            mcCalendario1.SelectionStart = dtpCalendario2.Value;
            txaFecha.Text = Convert.ToString(dtpCalendario2.Value);
        }
    }
}
