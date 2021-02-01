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
    public partial class extraordinarios : Form
    {
        private Conexion conexion;
        public extraordinarios(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void extraordinarios_Load(object sender, EventArgs e)
        {
            data_extra.DataSource = conexion.leer_extraordinarios();
        }
    }
}
