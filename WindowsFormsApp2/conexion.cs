using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;


        public conexion()
        {
            try
            {

                cn = new SqlConnection("Data Source=SALA235-PC05SQLEXPRESS;Initial Catalog=ConsultorioSonrrisaPerfecta;User ID=sa;Password=***********");
                cn.Open();
                MessageBox.Show("Conectado");

            }

            catch (Exception ex)
            {

                MessageBox.Show("No se conecto con la base de datos: " +ex.ToString());
            }

    }

        }





    }

    
    
    

    
    
    





