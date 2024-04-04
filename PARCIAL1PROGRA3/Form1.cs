using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PARCIAL1PROGRA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Controlador = new ControladorInscripcionTalleres();
            CargarDatos();
 
        }

        private void CargarDatos()
        {
            Controlador.CargarDatos("alumnos.txt", "talleres.txt", "inscripciones.txt");
            ActualizarListas();
        }

        private void ActualizarListas()
        {
            // Actualizar lista de alumnos
            listBoxAlumnos.Items.Clear();
            foreach (var alumno in Controlador.ObtenerNombresDeAlumnos())
            {
                listBoxAlumnos.Items.Add(alumno);
            }

            // Actualizar lista de talleres
            listBoxTalleres.Items.Clear();
            foreach (var taller in Controlador.ObtenerNombresDeTalleres())
            {
                listBoxTalleres.Items.Add(taller);
            }

            // Actualizar reporte de inscripciones
            textBoxReporte.Text = Controlador.GenerarReporte();
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            string nombreAlumno = listBoxAlumnos.SelectedItem?.ToString();
            string nombreTaller = listBoxTalleres.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nombreAlumno) && !string.IsNullOrEmpty(nombreTaller))
            {
                InscribirAlumnoEnTaller(nombreAlumno, nombreTaller);
                ActualizarListas();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un alumno y un taller.");
            }
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            Controlador.OrdenarReportePorNombreDeTaller();
            ActualizarListas();
        }

        private void buttonTotalInscritos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cantidad total de estudiantes inscritos: {controlador.ObtenerCantidadTotalDeEstudiantesInscritos()}");
        }
    }

}
