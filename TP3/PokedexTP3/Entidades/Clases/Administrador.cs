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

        static Administrador()
        {
            listaAdministradores = new List<Administrador>();
            HardcodearAdministradores();
        }
        public Administrador(string nombre, string apellido, string user, string password)
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

        public static void HardcodearAdministradores()
        {
            Administrador administrador1 = new Administrador("Samuel", "Oak", "ProfesorOak", "pueblopaleta");
            Administrador administrador2 = new Administrador("Enfermera", "Joy", "EnfermeraJoy", "centropokemon");

            listaAdministradores.Add(administrador1);
            listaAdministradores.Add(administrador2);
        }

        //Implementa la interfaz IDatos
        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {NombreCompleto}, user: {user}");

            return sb.ToString();
        }

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
