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

        public List<calificaciones> leer_promedio_total() => conn.leer_promedio_total();

        public List<calificaciones> leer_promedio_parcial() => conn.leer_promedio_parcial();

        public List<materia> leer_extraordinarios() => conn.leer_extraordinarios();

        public List<materia> leer_materias_adeudadas(int matricula) => conn.leer_materias_adeudadas(matricula);

        public bool agregar_alumno(string nombre, string apellido, int matricula) => conn.agregar_alumno(nombre,apellido,matricula);
    }
}
