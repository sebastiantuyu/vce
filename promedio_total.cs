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
    public partial class promedio_total : Form
    {
        private Conexion conexion;
        public promedio_total(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void promedio_total_Load(object sender, EventArgs e)
        {
            data_promedio.DataSource = conexion.leer_promedio_total();
        }
    }
}
