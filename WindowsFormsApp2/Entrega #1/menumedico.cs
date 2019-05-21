using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void bttAgendadecita_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void bttRequisitodepaciente_Click(object sender, EventArgs e)
        {
            Informacionpacientemedico form = new Informacionpacientemedico();
            form.Show();
            this.Hide();
        }

        private void bttTratamiento_Click(object sender, EventArgs e)
        {
            tratamientomedico form = new tratamientomedico();
            form.Show();
            this.Hide();
        }

        private void bttRegresar_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            Hide();
        }

        private void bttReportes_Click(object sender, EventArgs e)
        {
            Informacionpacientemedico form = new Informacionpacientemedico();
            form.Show();
            this.Hide();
        }
    }
}
