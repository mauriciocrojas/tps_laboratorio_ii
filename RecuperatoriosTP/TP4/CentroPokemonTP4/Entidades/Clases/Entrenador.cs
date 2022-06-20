using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Entrenador : IDatos
    {
        public string nombre;
        public string apellido;
        public string user;
        public string password;
        public static List<Entrenador> listaEntrenadores;

        /// <summary>
        /// Constructor estático que instancia y hardcodea la lista. 
        /// </summary>
        static Entrenador()
        {
            listaEntrenadores = new List<Entrenador>();
            HardcodearEntrenadores();
        }

        /// <summary>
        /// Constructor de instancia que recibe parámetros del entrenador.
        /// </summary>
        /// <param name="nombre">Nombre del entrenador</param>
        /// <param name="apellido">Apellido del entrenador</param>
        /// <param name="user">Usuario  del entrenador</param>
        /// <param name="password">Password del entrenador</param>
        public Entrenador(string nombre, string apellido, string user, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.user = user;
            this.password = password;
        }

        /// <summary>
        /// Propiedad que devuelve el nombre completo del entrenador.
        /// </summary>
        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        /// <summary>
        /// Función que muestra los datos de un entrenador, e implementa la interfaz IDatos.
        /// </summary>
        /// <returns>Retorna los datos del entrenador</returns>
        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {NombreCompleto}, user: {user}");

            return sb.ToString();
        }

        /// <summary>
        /// Función que muestra los datos de todos los entrenadores del sistema.
        /// </summary>
        /// <returns>Retorna los datos de todos los entrenadores</returns>
        public static string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Entrenador entrenador in listaEntrenadores)
            {
                sb.AppendLine($"{entrenador.MostrarDato()}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Función estática que hardcodea los entrenadores.
        /// </summary>
        public static void HardcodearEntrenadores()
        {
            Entrenador entrenador1 = new Entrenador("Ash", "Ketchum", "AshKetchum", "charizard");
            Entrenador entrenador2 = new Entrenador("Misty", "Celeste", "MistyCeleste", "cascada");
            Entrenador entrenador3 = new Entrenador("Brock", "Plateada", "BrockPlateada", "kanto");
            Entrenador entrenador4 = new Entrenador("Gary", "Oak", "GaryOak", "blastoise");
            Entrenador entrenador5 = new Entrenador("James", "Mememes", "JamesMememes", "meowth");

            listaEntrenadores.Add(entrenador1);
            listaEntrenadores.Add(entrenador2);
            listaEntrenadores.Add(entrenador3);
            listaEntrenadores.Add(entrenador4);
            listaEntrenadores.Add(entrenador5);
        }

    }
}
