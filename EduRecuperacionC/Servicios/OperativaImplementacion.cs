using EduRecuperacionC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void altaAlumno(List<AlumnoDto> listaAlumnos)
        {
                FicheroInterfaz fichero = new FicheroImplementacion();
                string mensaje;
            try { 

                AlumnoDto alumnoNuevo = new AlumnoDto();

                Console.WriteLine("Nombre del alumno");
                alumnoNuevo.Nombre = Console.ReadLine();

                Console.WriteLine("Apellido 1 del alumno");
                alumnoNuevo.Apellido1 = Console.ReadLine();

                Console.WriteLine("Apellido 2 del alumno");
                alumnoNuevo.Apellido2 = Console.ReadLine();

                Console.WriteLine("DNI del alumno");
                alumnoNuevo.Dni = Console.ReadLine();

                Console.WriteLine("Dirección del alumno");
                alumnoNuevo.Direccion = Console.ReadLine();

                Console.WriteLine("Teléfono del alumno");
                alumnoNuevo.Telefono = Console.ReadLine();

                Console.WriteLine("email del alumno");
                alumnoNuevo.Email = Console.ReadLine();

                alumnoNuevo.Id = idAuto(listaAlumnos);

                listaAlumnos.Add(alumnoNuevo);
                mensaje = "Alumno añadido correctamente";

                fichero.escribirFichero(mensaje);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al añadir el nuevo alumno" + ex.Message);
                mensaje = "Error al añadir el alumno a la lista";
                fichero.escribirFichero(mensaje);
                throw;
                
            }

        }

        /// <summary>
        /// Método que de manera automática va contando los id.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        private long idAuto(List<AlumnoDto> listaAlumnos)
        {

            int tamanioLista = listaAlumnos.Count;

            long id;

            if(listaAlumnos.Count > 0)
            {
                id = listaAlumnos[tamanioLista - 1].Id + 1;
            }
            else
            {
                id = 1;
            }

            return id;

        }
    }
}
