using SQLiteDb;
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
    public partial class materias_adeudadas : Form
    {
        private Conexion conexion;
        public materias_adeudadas(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            data_alumnos.ValueMember = "Matricula";
            data_alumnos.DisplayMember = "Nombre";
            data_alumnos.DataSource = conexion.leer_alumnos();
        }

        private void materias_adeudadas_Load(object sender, EventArgs e)
        {
        }

        private void obtener_Click(object sender, EventArgs e)
        {
            data_materias.DataSource = conexion.leer_materias_adeudadas((int)data_alumnos.SelectedValue);
        }

        private void data_alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            matricula.Text = data_alumnos.SelectedValue.ToString();    
        }
    }
}
