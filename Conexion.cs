using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace ControlEscolar
{

    public class Conexion
    {

        private SQLiteConn conn;
        //Inicializa el constructor
        public Conexion()
        {
            conn = new SQLiteConn("control_escolar.db", true);
        }

        //Cerrar programa
        public void Close() => conn.Close();

        public List<alumnos> leer_alumnos() => conn.leer_alumnos();

        public List<materias> leer_materias() => conn.leer_materias();


    }
}
