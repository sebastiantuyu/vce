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
    public partial class mostrar_materias : Form
    {
        private Conexion conexion;
        public mostrar_materias(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }



        private void mostrar_materias_Load(object sender, EventArgs e)
        {
            data_materias.DataSource = conexion.leer_materias();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
