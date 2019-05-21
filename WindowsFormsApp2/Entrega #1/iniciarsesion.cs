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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttingresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Odontologia" && txtclave.Text == "1234")
            {
                form5 form = new form5();
                form.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("El usuario no es valido", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusuariopaciente.Text == "Paciente" && txtclavepaciente.Text == "1234")
            {
                menupaciente form = new menupaciente();
                form.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("El usuario no es valido", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
    
