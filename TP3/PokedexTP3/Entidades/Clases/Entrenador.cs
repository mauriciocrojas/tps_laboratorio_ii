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

        static Entrenador()
        {
            listaEntrenadores = new List<Entrenador>();
            HardcodearEntrenadores();
        }

        private Entrenador()
        {

        }
        public Entrenador(string nombre, string apellido, string user, string password) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.user = user;
            this.password = password;
        }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        //Implementa la interfaz IDatos
        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {NombreCompleto}, user: {user}");

            return sb.ToString();
        }

        public static string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Entrenador entrenador in listaEntrenadores)
            {
                sb.AppendLine($"{entrenador.MostrarDato()}");
            }

            return sb.ToString();
        }


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
