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
    public partial class ControlPrincipal : Form
    {

        private Conexion conection;
        public ControlPrincipal()
        {
            InitializeComponent();
            //Hacemos la conexion con la base de datos
            conection = new Conexion();
        }

        // Controles basicos: cerrar programa
        private void exit_Click(object sender, EventArgs e)
        {
            //Cerrar conexion base de datos
            conection.Close();
            // Cerrar programa
            Close();
        }

        //Mostrar alumnos existentes ordenados por matricula
        private void alumnos_existentes_Click(object sender, EventArgs e)
        {

        }

        //Mostrar materias existentes ordenadas por clave
        private void materias_existentes_Click(object sender, EventArgs e)
        {
        }

        // Dar de alta un alumno
        private void alta_alumnos_Click(object sender, EventArgs e)
        {

        }

        // Modificar calificaciones de un alumno
        private void modificar_calificaciones_Click(object sender, EventArgs e)
        {

        }

        // Mostrar promedio total de alumnos
        private void promedio_total_Click(object sender, EventArgs e)
        {

        }

        // Mostrar promedio parcial de alumnos
        private void promedio_parcial_Click(object sender, EventArgs e)
        {

        }


        //Mostrar materias adeudadas por alumno
        private void materias_adeudadas_Click(object sender, EventArgs e)
        {

        }

        //Mostrar extraordinarios
        private void extraordinarios_Click(object sender, EventArgs e)
        {

        }

        //Muestra texto de ayuda: alumnos existentes
        private void alumnos_existentes_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Esta funcion muestra a todos los alumnos organizados por matricula";
        }
    }
}
