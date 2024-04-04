using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1PROGRA3
{
    class ControladorInscripcionTalleres
    {
        private List<Alumno> alumnos = new List<Alumno>();
        private List<Taller> talleres = new List<Taller>();
        private List<Inscripcion> inscripciones = new List<Inscripcion>();
        private List<Controlador> controlador = new List<Controlador>();
  

        // Método para cargar los datos de los archivos de texto
        public void CargarDatos(string rutaAlumnos, string rutaTalleres, string rutaInscripciones)
        {
            // Cargar datos de los alumnos desde el archivo
            foreach (string linea in File.ReadAllLines(rutaAlumnos))
            {
                string[] partes = linea.Split(',');
                alumnos.Add(new Alumno
                {
                    DPI = partes[0],
                    Nombre = partes[1],
                    Direccion = partes[2]
                });
            }

            // Cargar datos de los talleres desde el archivo
            foreach (string linea in File.ReadAllLines(rutaTalleres))
            {
                string[] partes = linea.Split(',');
                talleres.Add(new Taller
                {
                    Codigo = partes[0],
                    Nombre = partes[1],
                    Costo = decimal.Parse(partes[2])
                });
            }

            // Cargar datos de las inscripciones desde el archivo
            foreach (string linea in File.ReadAllLines(rutaInscripciones))
            {
                string[] partes = linea.Split(',');
                inscripciones.Add(new Inscripcion
                {
                    DPIDelEstudiante = partes[0],
                    CodigoDelTaller = partes[1],
                    FechaDeInscripcion = DateTime.Parse(partes[2])
                });
            }
        }

        // Método para inscribir a un alumno en un taller
        public void InscribirAlumnoEnTaller(string nombreAlumno, string nombreTaller)
        {
            Alumno alumno = alumnos.Find(a => a.Nombre == nombreAlumno);
            Taller taller = talleres.Find(t => t.Nombre == nombreTaller);
            if (alumno != null && taller != null)
            {
                inscripciones.Add(new Inscripcion
                {
                    DPIDelEstudiante = alumno.DPI,
                    CodigoDelTaller = taller.Codigo,
                    FechaDeInscripcion = DateTime.Today
                });
            }
            else
            {
                Console.WriteLine("No se pudo encontrar al alumno o al taller.");
            }
        }

        // Método para generar un reporte de inscripciones
        public void GenerarReporte()
        {
            foreach (var inscripcion in inscripciones)
            {
                Alumno alumno = alumnos.Find(a => a.DPI == inscripcion.DPIDelEstudiante);
                Taller taller = talleres.Find(t => t.Codigo == inscripcion.CodigoDelTaller);
                if (alumno != null && taller != null)
                {
                    Console.WriteLine($"Alumno: {alumno.Nombre}, Taller: {taller.Nombre}");
                }
            }
        }

        // Método para ordenar alfabéticamente el reporte de inscripciones por nombre del taller
        public void OrdenarReportePorNombreDeTaller()
        {
            inscripciones.Sort((i1, i2) =>
            {
                Taller taller1 = talleres.Find(t => t.Codigo == i1.CodigoDelTaller);
                Taller taller2 = talleres.Find(t => t.Codigo == i2.CodigoDelTaller);
                if (taller1 != null && taller2 != null)
                {
                    return taller1.Nombre.CompareTo(taller2.Nombre);
                }
                return 0;
            });
        }

        // Método para obtener la cantidad total de estudiantes inscritos
        public int ObtenerCantidadTotalDeEstudiantesInscritos()
        {
            return inscripciones.Count;
        }
    }
}

