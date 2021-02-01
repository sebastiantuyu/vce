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
            error.Visible = false;
            //Cargar informacion alumnos
            alumno_box.DisplayMember = "Nombre";
            alumno_box.ValueMember = "Matricula";
            alumno_box.DataSource = conexion.leer_alumnos();

            //Cargar informacion materias
            materia_box.DisplayMember = "nombre";
            materia_box.ValueMember = "clave";
            materia_box.DataSource = conexion.leer_materias();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alumno = alumno_box.SelectedValue.ToString();
            string materia = materia_box.SelectedValue.ToString();
            string calificacion = calificacion_box.Text;
            int calificacion_ = Convert.ToInt32(calificacion);
            //Si todos los campos estan llenos entonces...
            if (!String.IsNullOrEmpty(alumno) && !String.IsNullOrEmpty(materia) && !String.IsNullOrEmpty(calificacion))
            {
                // Si la calificacion es un numero valido entonces ...
                if (calificacion_>0 && calificacion_<100)
                {
                    if(conexion.modificar_calificaciones(Convert.ToInt32(alumno), Convert.ToInt32(materia), calificacion_))
                    {
                        MessageBox.Show("Calificacion agregada correctamente","Informacion",MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Problemas agregando la calificacion", "Informacion", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // Si no introdujo una calificacion correcta entonces...
                    error.Visible = true;
                }
            }
        }
    }
}
