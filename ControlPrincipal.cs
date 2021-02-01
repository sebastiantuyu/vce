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

        

    }
}
