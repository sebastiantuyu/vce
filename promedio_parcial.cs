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
    public partial class promedio_parcial : Form
    {

        private Conexion conexion;
        public promedio_parcial(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void promedio_parcial_Load(object sender, EventArgs e)
        {
            data_promedio.DataSource = conexion.leer_promedio_parcial();
        }
    }
}
