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
    public partial class mostrar_alumnos : Form
    {
        private Conexion conexion;

        public mostrar_alumnos(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void mostrar_alumnos_Load(object sender, EventArgs e)
        {
            data_alumnos.DataSource = conexion.leer_alumnos();
        }
    }
}
