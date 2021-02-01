using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace ControlEscolar
{

    class Conexion
    {

        private SQLiteConn conn;
        //Inicializa el constructor
        public Conexion()
        {
            conn = new SQLiteConn("contro_escolar.db", true);
        }

        //Cerrar programa
        public void Close() => conn.Close();

    }
}
