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
    public partial class tratamientomedico : Form
    {
        public tratamientomedico()
        {
            InitializeComponent();
        }

        private void bttRegresar_Click(object sender, EventArgs e)
        {
            form5 x = new form5();
            x.Show();
            Hide();
        }

        private void bttguardar_Click(object sender, EventArgs e)
        {

            if (!ValidarDatos())
            {
                return;
            }
            string NombreDelTratamiento = txtNombre.Text;
            string Descripcion = txtDescripcion.Text;
            string CostosAproximados = txtcostos.Text;
            string Cuidadosespeciales = txtcuidados.Text;
            
            tratamientomedico control = new tratamientomedico();


            MessageBox.Show("Los datos se han guardado exitosamente");
        }




        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                errorMensaje.SetError(txtNombre, "Por favor ingrese el nombre del tratamiento");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtNombre, null);
            }


            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                errorMensaje.SetError(txtDescripcion, "Por favor ingrese la descripcion del tratamiento");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtDescripcion, null);
            }

            if (string.IsNullOrEmpty(txtcostos.Text.Trim()))
            {
                errorMensaje.SetError(txtcostos, "Por favor ingrese el costo aproximado del tratamiento");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtcostos, null);
            }
           
            if (string.IsNullOrEmpty(txtcuidados.Text.Trim()))
            {
                errorMensaje.SetError(txtcuidados, "Por favor ingrese los cuidados del tratamiento");
                return false;
            }
            else
            {
                errorMensaje.SetError(txtcuidados, null);

            }
          

             return true;
        }
    }
}










