using EduRecuperacionC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Interfaz que contiene los métodos de la operativa de la aplicación.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>

    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que contiene la operativa del alta alumno, y lo añade a la lista de alumnos.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public void altaAlumno(List<AlumnoDto> listaAlumnos);
    }
}
