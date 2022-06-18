using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public class Pokemon : IDatos
    {
        public string nombre;
        public string tipo;
        public int id;
        public string ataquePrincipal;
        public int danio;
        static List<Pokemon> listaPokemon;

        static string rutaEscritorio;
        static string nombreCarpeta;
        static string rutaEscritorioYCarpeta;


        /// <summary>
        /// Constructor estático que instancia y hardcodea la lista. 
        /// </summary>
        static Pokemon()
        {
            listaPokemon = new List<Pokemon>();
            HardcodearPokemon();
            rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            nombreCarpeta = @"/Listados Pokemon";
            rutaEscritorioYCarpeta = rutaEscritorio + nombreCarpeta;
        }

        /// <summary>
        /// Creo este constructor para poder serializar en XML.
        /// </summary>
        public Pokemon() { }

        /// <summary>
        /// Constructor de instancia que recibe parámetros del pokemon.
        /// </summary>
        /// <param name="nombre">Nombre del pokemon</param>
        /// <param name="tipo">Tipo del pokemon</param>
        /// <param name="id">Id  del pokemon</param>
        /// <param name="ataquePrincipal">Ataque principal del pokemon</param>
        /// <param name="danio">Daño que presenta el pokemon</param>
        public Pokemon(string nombre, string tipo, int id, string ataquePrincipal, int danio)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.id = id;
            this.ataquePrincipal = ataquePrincipal;
            this.danio = danio;
        }

        /// <summary>
        /// Propiedad para acceder y escribir en la lista.
        /// </summary>
        public static List<Pokemon> ListaPokemon { get => listaPokemon; set => listaPokemon = value; }

        /// <summary>
        /// Función estática que hardcodea los pokemon.
        /// </summary>
        public static void HardcodearPokemon()
        {
            Pokemon Bulbasaur = new Pokemon("Bulbasaur", "Planta-Veneno", 1, "Hoja afilada", 50);
            Pokemon Ivysaur = new Pokemon("Ivysaur", "Planta-Veneno", 2, "Síntesis", 25);
            Pokemon Venusaur = new Pokemon("Venusaur", "Planta-Veneno", 3, "Rayo solar", 33);
            Pokemon Charmander = new Pokemon("Charmander", "Fuego", 4, "Lanzallamas", 98);
            Pokemon Charmeleon = new Pokemon("Charmeleon", "Fuego", 5, "Giro fuego", 15);
            Pokemon Charizard = new Pokemon("Charizard", "Fuego-Volador", 6, "Furia dragón", 73);
            Pokemon Squirtle = new Pokemon("Squirtle", "Agua", 7, "Pistola de agua", 61);
            Pokemon Wartortle = new Pokemon("Wartortle", "Agua", 8, "Cabezazo", 58);
            Pokemon Blastoise = new Pokemon("Blastoise", "Agua", 9, "Hidrobomba", 89);

            listaPokemon.Add(Bulbasaur);
            listaPokemon.Add(Ivysaur);
            listaPokemon.Add(Venusaur);
            listaPokemon.Add(Charmander);
            listaPokemon.Add(Charmeleon);
            listaPokemon.Add(Charizard);
            listaPokemon.Add(Squirtle);
            listaPokemon.Add(Wartortle);
            listaPokemon.Add(Blastoise);
        }

        /// <summary>
        /// Método que creará un archivo txt con el listado de pokemon alojados en el centro.
        /// </summary>
        public static void EscribirXml(List<Pokemon> pokemon)
        {
            string nombreArchivo = @"/Listado de Pokemon en el Centro.xml";
            string rutaCompleta = rutaEscritorioYCarpeta + nombreArchivo;

            if (!Directory.Exists(rutaEscritorioYCarpeta))
            {
                Directory.CreateDirectory(rutaEscritorioYCarpeta);
            }

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pokemon>));
                xmlSerializer.Serialize(sw, pokemon);
            }
        }

        /// <summary>
        /// Método que leerá el archivo pasado como parámetro, y lo mostrará en el RichTextBox.
        /// </summary>
        /// <param name="archivo">Nombre de Archivo a leer</param>
        /// <returns>Retorna el contenido del archivo en formato string</returns>
        public static List<Pokemon> LeerXml()
        {
            string rutaCompleta = rutaEscritorioYCarpeta + @"/Listado de Pokemon en el Centro.xml";
            List<Pokemon> listaPokemon;

            if (Directory.Exists(rutaEscritorioYCarpeta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pokemon>));
                    listaPokemon = (List<Pokemon>)xmlSerializer.Deserialize(sr);

                    return listaPokemon;
                }
            }

            return null;
        }

        /// <summary>
        /// Método que creará un archivo txt con el listado de pokemon alojados en el centro.
        /// </summary>
        public static void EscribirTxt()
        {
            //string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;
            //string nombreArchivo = @"/Listado de Pokemon en el Centro al " + DateTime.Now.ToString("dd_MM_yy HH.mm") + ".txt";

            string nombreArchivo = @"/Listado de Pokemon en el Centro.txt";
            string rutaCompleta = rutaEscritorioYCarpeta + nombreArchivo;

            if (!Directory.Exists(rutaEscritorioYCarpeta))
            {
                Directory.CreateDirectory(rutaEscritorioYCarpeta);
            }

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                sw.WriteLine(Pokemon.MostrarDatos());
            }
        }

        /// <summary>
        /// Método que leerá el archivo pasado como parámetro, y lo mostrará en el RichTextBox.
        /// </summary>
        /// <param name="archivo">Nombre de Archivo a leer</param>
        /// <returns>Retorna el contenido del archivo en formato string</returns>
        public static string LeerTxt(string archivo)
        {
            string rutaCompleta = rutaEscritorioYCarpeta + archivo;
            string datos = string.Empty;

            try
            {
                if (Directory.Exists(rutaEscritorioYCarpeta))
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {
                        datos = sr.ReadToEnd();
                        return datos;
                    }
                }
                else
                {
                    return datos;
                }
            }
            catch (Exception)
            {
                return datos;
            }
        }


        /// <summary>
        /// Función que muestra los datos de un pokemon, e implementa la interfaz IDatos.
        /// </summary>
        /// <returns>Retorna los datos del pokemon</returns>
        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"ID: {id}\nNombre: {nombre}\nTipo: {tipo}\nAtaque principal: {ataquePrincipal}\nNivel de daño: {danio}%");

            return sb.ToString();
        }

        /// <summary>
        /// Función que muestra los datos de todos los pokemon del sistema.
        /// </summary>
        /// <returns>Retorna los datos de todos los pokemon</returns>
        public static string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pokemon pokemon in listaPokemon)
            {
                sb.AppendLine($"{pokemon.MostrarDato()}\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Función que agrega un pokemon a la lista si pasa las validaciones.
        /// </summary>
        /// <param name="nombre">Nombre del pokemon</param>
        /// <param name="tipo">Tipo del pokemon</param>
        /// <param name="id">Id del pokemon</param>
        /// <param name="ataque">Ataque del pokemon</param>
        /// <param name="danio">Danio del pokemon</param>
        /// <returns>Retorna true en caso de agregar a la lista, false caso contrario</returns>
        public static bool AgregarPokemonManual(string nombre, string tipo, int id, string ataque, int danio)
        {
            foreach (Pokemon itempokemon in listaPokemon)
            {
                if (itempokemon.nombre == nombre || itempokemon.id == id)
                {
                    return false;
                }
            }
            Pokemon pokemon = new Pokemon(nombre, tipo, id, ataque, danio);
            listaPokemon.Add(pokemon);
            return true;
        }
    }
}
