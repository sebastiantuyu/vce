using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class alta_alumno : Form
    {
        private Conexion conexion;
        public alta_alumno(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            error.Visible = false;
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            //Nombre, apellido, matricula
            string nombre = nombre_box.Text;
            string apellido = apellido_box.Text;
            string matricula = matricula_box.Text;
            // Comprueba que todos los campos esten llenos            
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(matricula))
            {
             conexion.agregar_alumno(nombre, apellido, Convert.ToInt32(matricula));
            }
            else {
                //Si no estan llenos, muestra el aviso de error en pantalla 
                error.Visible = true;
            }

        }
    }
}
