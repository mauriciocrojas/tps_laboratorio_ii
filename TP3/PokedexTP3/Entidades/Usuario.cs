using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public class Usuario
    {
        public string nombre;
        public string apellido;
        public string user;
        public string password;
        public static List<Usuario> listaUsuarios;

        static Usuario()
        {
            listaUsuarios = new List<Usuario>();
            HardcodearUsuarios();
        }
        public Usuario(string nombre, string apellido, string user, string password)
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

        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {NombreCompleto}, user: {user}");

            return sb.ToString();
        }


        public static void HardcodearUsuarios()
        {
            Usuario usuario1 = new Usuario("Ariel", "Perez", "aperez", "arielsito");
            Usuario usuario2 = new Usuario("Brian", "Lega", "blega", "thebrian");
            Usuario usuario3 = new Usuario("Carlos", "Bom", "cbom", "carlitos");
            Usuario usuario4 = new Usuario("Denver", "Hetok", "dhetok", "denverland");
            Usuario usuario5 = new Usuario("Emul", "Asion", "easion", "emular");


            listaUsuarios.Add(usuario1);
            listaUsuarios.Add(usuario2);
            listaUsuarios.Add(usuario3);
            listaUsuarios.Add(usuario4);
            listaUsuarios.Add(usuario5);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Usuario usuario in listaUsuarios)
            {
                sb.AppendLine($"{usuario.MostrarDato()}");
            }

            return sb.ToString();
        }


    }
}
