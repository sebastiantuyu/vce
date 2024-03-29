﻿using System;
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
    public class calificaciones
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        public double Calificacion { get; set; }


        public calificaciones(string nombre, string apellido,int matricula,double calificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
            Calificacion = calificacion;
        }
    }

    public class materia
    {
        public string Nombre { get; }
        public int Data { get; }

        public materia(string nombre, int data)
        {
            Nombre = nombre;
            Data = data;
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
        
        //Leer el promedio total de cada alumno
        public List<calificaciones> leer_promedio_total()
        {
            string query = "SELECT ALUMNOS.NOMBRE,ALUMNOS.APELLIDO, "
                            +"CALIFICACIONES.ALUMNOid AS MATRICULA, "
                            +"AVG(CALIFICACIONES.CALIFICACION) AS CALIFICACION "
                            +"FROM CALIFICACIONES "
                            +"INNER JOIN ALUMNOS ON "
                            +"(ALUMNOS.MATRICULA = CALIFICACIONES.ALUMNOid) "
                            +"WHERE CALIFICACION>0 "
                            +"GROUP BY MATRICULA "
                            +"ORDER BY CALIFICACION ";
            List<calificaciones> lista_calificaciones = new List<calificaciones>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_calificaciones.Add(new calificaciones(rs.GetString("NOMBRE"), rs.GetString("APELLIDO"), rs.GetInt32("MATRICULA"), rs.GetDouble("CALIFICACION")));
                }
            }
            return lista_calificaciones;

        }

        //Leer el promedio parcial de cada alumno
        public List<calificaciones> leer_promedio_parcial()
        {
            string query = "SELECT ALUMNOS.NOMBRE,ALUMNOS.APELLIDO, "
                            + "CALIFICACIONES.ALUMNOid AS MATRICULA, "
                            + "AVG(CALIFICACIONES.CALIFICACION) AS CALIFICACION "
                            + "FROM CALIFICACIONES "
                            + "INNER JOIN ALUMNOS ON "
                            + "(ALUMNOS.MATRICULA = CALIFICACIONES.ALUMNOid) "
                            + "WHERE CALIFICACION>69 "
                            + "GROUP BY MATRICULA "
                            + "ORDER BY CALIFICACION ";
            List<calificaciones> lista_calificaciones = new List<calificaciones>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_calificaciones.Add(new calificaciones(rs.GetString("NOMBRE"), rs.GetString("APELLIDO"), rs.GetInt32("MATRICULA"), rs.GetDouble("CALIFICACION")));
                }
            }
            return lista_calificaciones;

        }

        //Leer las materias que tienen alumnos reprobados en ellas
        public List<materia> leer_extraordinarios()
        {
            string query = "SELECT MATERIAS.MATERIA AS MATERIA, "
                            + "COUNT(CALIFICACIONES.CALIFICACION) AS EXTRAORDINARIOS "
                            + "FROM MATERIAS "
                            + "INNER JOIN CALIFICACIONES ON "
                            + "(MATERIAS.CLAVE = CALIFICACIONES.MATERIAid) "
                            + "WHERE CALIFICACIONES.CALIFICACION < 69 "
                            + "AND CALIFICACIONES.CALIFICACION > 0 "
                            + "GROUP BY MATERIAS.CLAVE ";
            List<materia> lista_materia = new List<materia>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_materia.Add(new materia(rs.GetString("MATERIA"),rs.GetInt32("EXTRAORDINARIOS")));
                }
            }
            return lista_materia;
        }
        
        //Leer las materias que ha reprobado un alumno dependiendo de la matricula
        public List<materia> leer_materias_adeudadas(int matricula)
        {
            string query = "SELECT MATERIAS.MATERIA AS MATERIA, "
                            + "CALIFICACIONES.CALIFICACION AS CALIFICACION "
                            + "FROM ALUMNOS "
                            + "INNER JOIN CALIFICACIONES ON "
                            + "(CALIFICACIONES.ALUMNOid = ALUMNOS.MATRICULA) "
                            + "INNER JOIN MATERIAS ON "
                            + "(CALIFICACIONES.MATERIAid = MATERIAS.CLAVE) "
                            + "WHERE CALIFICACIONES.CALIFICACION < 69 "
                            + "AND CALIFICACIONES.CALIFICACION > 0 "
                            + $"AND ALUMNOS.MATRICULA = {matricula}";
            List<materia> lista_materia = new List<materia>();
            using (SQLiteRecordSet rs = ExecuteQuery(query))
            {
                while (rs.NextRecord())
                {
                    lista_materia.Add(new materia(rs.GetString("MATERIA"), rs.GetInt32("CALIFICACION")));
                }
            }
            return lista_materia;
        }

        public bool agregar_alumno(string nombre, string apellido, int matricula)
        {

            string query = "INSERT INTO ALUMNOS (NOMBRE,APELLIDO,MATRICULA) "
                            + "VALUES( "
                            + $"'{nombre}', "
                            + $"'{apellido}', "
                            + $"{matricula} "
                            + ") ";
            ExecuteNonQuery(query);
            //Agrega automaticamente todas sus calificaciones en -1
            if (default_calificaciones(matricula))
            {            
                //Si se agregan correctamente las califiaciones (devuelve verdadero)
                //Entonces ejecuta verdadero
                return true;
            }
            return false;
        }

        public bool modificar_calificaciones(int matricula, int clave, int calificacion)
        {
            string query = "INSERT INTO CALIFICACIONES(ALUMNOid,MATERIAid,CALIFICACION) "
                            +"VALUES "
                            +$"({matricula}, {clave}, {calificacion}) ";
            ExecuteNonQuery(query);
            return true;
        }

        // Genera un metodo que agrega calificaciones a un alumno recien creado
        // Y las pone todas en -1
        private bool default_calificaciones(int matricula)
        {
            string query = "INSERT INTO CALIFICACIONES(ALUMNOid,MATERIAid,CALIFICACION) "
                            + "VALUES "
                            + $"/* MICROCONT  */    ({matricula}, 37158, -1), "
                            + $"/* ROBOTICA   */    ({matricula}, 37965, -1), "
                            + $"/* CALCULO    */    ({matricula}, 42295, -1), "
                            + $"/* MECANISMOS */    ({matricula}, 45865, -1), "
                            + $"/* SISTEMASD  */    ({matricula}, 49201, -1), "
                            + $"/* VIBRACION  */    ({matricula}, 68799, -1), "
                            + $"/* QUIMICA    */    ({matricula}, 77455, -1), "
                            + $"/* PROGRAMAC  */    ({matricula}, 87615, -1), "
                            + $"/* ALGEBRA    */    ({matricula}, 93806, -1), "
                            + $"/* CONTROL    */    ({matricula}, 97346, -1) ";
            ExecuteNonQuery(query);
            return true;
        }
        
        
    }
}
