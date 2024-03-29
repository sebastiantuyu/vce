﻿using System;
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

        private Conexion conexion;
        public ControlPrincipal()
        {
            InitializeComponent();
            //Hacemos la conexion con la base de datos
            conexion = new Conexion();
        }

        // Controles basicos: cerrar programa
        private void exit_Click(object sender, EventArgs e)
        {
            //Cerrar conexion base de datos
            conexion.Close();
            // Cerrar programa
            Close();
        }

        //Mostrar alumnos existentes ordenados por matricula
        private void alumnos_existentes_Click(object sender, EventArgs e)
        {
            mostrar_alumnos form = new mostrar_alumnos(conexion);
            form.ShowDialog();
        }

        //Mostrar materias existentes ordenadas por clave
        private void materias_existentes_Click(object sender, EventArgs e)
        {
            mostrar_materias form = new mostrar_materias(conexion);
            form.ShowDialog();
        }

        // Dar de alta un alumno
        private void alta_alumnos_Click(object sender, EventArgs e)
        {
            alta_alumno form = new alta_alumno(conexion);
            form.ShowDialog();
        }

        // Modificar calificaciones de un alumno
        private void modificar_calificaciones_Click(object sender, EventArgs e)
        {
            modifica_calificaciones form = new modifica_calificaciones(conexion);
            form.ShowDialog();
        }

        // Mostrar promedio total de alumnos
        private void promedio_total_Click(object sender, EventArgs e)
        {
            promedio_total form = new promedio_total(conexion);
            form.ShowDialog();
        }

        // Mostrar promedio parcial de alumnos
        private void promedio_parcial_Click(object sender, EventArgs e)
        {
            promedio_parcial form = new promedio_parcial(conexion);
            form.ShowDialog();
        }


        //Mostrar materias adeudadas por alumno
        private void materias_adeudadas_Click(object sender, EventArgs e)
        {
            materias_adeudadas form = new materias_adeudadas(conexion);
            form.ShowDialog();
        }

        //Mostrar extraordinarios
        private void extraordinarios_Click(object sender, EventArgs e)
        {
            extraordinarios form = new extraordinarios(conexion);
            form.ShowDialog();
        }

        //Muestra texto de ayuda
        private void alumnos_existentes_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Muestra a todos los alumnos organizados por matricula";
        }

        private void materias_existentes_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Muestra todas las materias organizadas por clave";
        }

        private void alta_alumnos_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Permite dar de alta a alumnos nuevos";
        }

        private void modificar_calificaciones_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Permite modificar las calificaciones de los alumnos";
        }

        private void promedio_total_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Regresa el promedio total de los alumnos";
        }

        private void promedio_parcial_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Regresa el promedio parcial de los alumnos";
        }

        private void materias_adeudadas_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Muestra los alumnos que tienen materias adeudadas";
        }

        private void extraordinarios_MouseHover(object sender, EventArgs e)
        {
            helper_content.Text = "Muestra la cantidad de alumnos que debieron cada materia";
        }
    }
}
