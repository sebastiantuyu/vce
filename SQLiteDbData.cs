using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SQLiteDb
{
    //Clases para importacion de datos
   public class alumnos
    {
        public int matricula { get; set; }
        public string nombre { get; set; }

        public alumnos(int matricula, string nombre)
        {
            this.matricula = matricula;
            this.nombre = nombre;
        }
    }
    

    public partial class SQLiteConn
    {
        // Metodos para el manejo de datos
        public List<alumnos> leer_alumnos()
        {
            
            string query = "SELECT * FROM ALUMNOS"
                            +"ORDER BY MATRICULA";
            List<alumnos> lista_alumnos = new List<alumnos>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_alumnos.Add(new alumnos(rs.GetInt32("MATRICULA"), rs.GetString("NOMBRE")));

                }
            }
            return lista_alumnos;
        }
    }
}
