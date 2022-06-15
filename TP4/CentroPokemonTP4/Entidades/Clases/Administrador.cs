using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Administrador : IDatos
    {
        public string nombre;
        public string apellido;
        public string user;
        public string password;
        public static List<Administrador> listaAdministradores;

        /// <summary>
        /// Constructor estático que instancia y hardcodea la lista. 
        /// </summary>
        static Administrador()
        {
            listaAdministradores = new List<Administrador>();
            HardcodearAdministradores();
        }

        /// <summary>
        /// Constructor de instancia que recibe parámetros del administrador.
        /// </summary>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="user">Usuario  del administrador</param>
        /// <param name="password">Password del administrador</param>
        public Administrador(string nombre, string apellido, string user, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.user = user;
            this.password = password;
        }

        /// <summary>
        /// Propiedad que devuelve el nombre completo del administrador.
        /// </summary>
        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        /// <summary>
        /// Función estática que hardcodea los administradores.
        /// </summary>
        public static void HardcodearAdministradores()
        {
            Administrador administrador1 = new Administrador("Enfermera", "Joy", "EnfermeraJoy", "centropokemon"); 
            Administrador administrador2 = new Administrador("Samuel", "Oak", "ProfesorOak", "pueblopaleta");

            listaAdministradores.Add(administrador1);
            listaAdministradores.Add(administrador2);
        }

        /// <summary>
        /// Función que muestra los datos de un administrador, e implementa la interfaz IDatos.
        /// </summary>
        /// <returns>Retorna los datos del administrador</returns>
        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {NombreCompleto}, user: {user}");

            return sb.ToString();
        }

        /// <summary>
        /// Función que muestra los datos de todos los administradores del sistema.
        /// </summary>
        /// <returns>Retorna los datos de todos los administradores</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Administrador administrador in listaAdministradores)
            {
                sb.AppendLine($"{administrador.MostrarDato()}");
            }

            return sb.ToString();
        }

    }
}
