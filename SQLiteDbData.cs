using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace SQLiteDb
{
    //Clases para importacion de datos
    public class alumnos
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public alumnos(int matricula, string nombre, string apellido)
        {
            this.Matricula = matricula;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
    public class materias
    {
        public int clave { get; }
        public string nombre { get; }
        public int creditos { get; }

        public materias(int clave,string nombre,int creditos)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.creditos = creditos;
        }

    }

    public partial class SQLiteConn
    {
        // Metodos para el manejo de datos
        //Leer todos los alumnos ordenados por matricula
        public List<alumnos> leer_alumnos()
        {
            
            string query = "SELECT * FROM ALUMNOS "
                            +"ORDER BY MATRICULA";
            List<alumnos> lista_alumnos = new List<alumnos>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_alumnos.Add(new alumnos(rs.GetInt32("MATRICULA"), rs.GetString("NOMBRE"), rs.GetString("APELLIDO")));
                }
            }
            return lista_alumnos;
        }

        //Leer todas las materias ordenadas por clave
        public List<materias> leer_materias()
        {
            string query = "SELECT CLAVE, MATERIA, CREDITOS FROM MATERIAS "
                           +"ORDER BY CLAVE";
            List<materias> lista_materias = new List<materias>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_materias.Add(new materias(rs.GetInt32("CLAVE"), rs.GetString("MATERIA"), rs.GetInt32("CREDITOS")));
                }
            }
            return lista_materias;
        }
    }
}
