using EduRecuperacionC.Dto;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Utils;

namespace EduRecuperacionC
{
    /// <summary>
    /// Class program donde se crea una lista estática de alumno y se encuentra el main.
    /// Carlos Haro Infante - 28/05/24
    /// </summary>

    class Program
    {
        public static List<AlumnoDto> alumno = new List<AlumnoDto>();

        /// <summary>
        /// Main del programa donde se encuentran las llamada a métodos, los case del menú, etc.
        /// Carlos Haro Infante - 28/05/24
        /// </summary>
        public static void Main(string[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            FicheroInterfaz escribe = new FicheroImplementacion();
            OperativaInterfaz operativa = new OperativaImplementacion();

            bool cerrarMenu = false;
            string mensaje;
            do
            {

                try
                {

                    int opcion = menu.menu();
                    mensaje = "Entra en el menú principal";
                    escribe.escribirFichero(mensaje);

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Se cierra el menú");
                            mensaje = "Se cierra el menú";
                            escribe.escribirFichero(mensaje);
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Alta de objeto");
                            mensaje = "Alta de objeto";
                            escribe.escribirFichero(mensaje);
                            operativa.altaAlumno(alumno);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            mensaje = "opción no válida";
                            escribe.escribirFichero(mensaje);
                            break;
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error Tipo IO " + ex.Message);
                    mensaje = "Error al elegir la opción en el menú principal" + ex.Message;
                    escribe.escribirFichero(mensaje);
                }
                

            }while (!cerrarMenu);


        }


    }

}
