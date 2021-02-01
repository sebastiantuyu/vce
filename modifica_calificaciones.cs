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
    public partial class modifica_calificaciones : Form
    {
        private Conexion conexion;
        public modifica_calificaciones(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            //Cargar informacion
            alumno_box.DisplayMember = ""
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alumno = (string)alumno_box.SelectedValue;
            string materia = (string)materia_box.SelectedValue;
            string calificacion = calificacion_box.Text;
            int calificacion_ = Convert.ToInt32(calificacion);
            //Si todos los campos estan llenos entonces...
            if (!String.IsNullOrEmpty(alumno) && !String.IsNullOrEmpty(materia) && !String.IsNullOrEmpty(calificacion))
            {
                // Si la calificacion es un numero valido entonces ...
                if (calificacion_>0 && calificacion_<100)
                {
                    conexion.modificar_calificaciones(Convert.ToInt32(alumno), Convert.ToInt32(materia), calificacion_);
                }
            }
        }
    }
}
