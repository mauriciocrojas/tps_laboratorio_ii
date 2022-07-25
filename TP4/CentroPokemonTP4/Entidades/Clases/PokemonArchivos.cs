using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Entidades.Clases
{
    public class PokemonArchivos
    {

        static string rutaEscritorio;
        static string nombreCarpeta;
        static string rutaEscritorioYCarpeta;

        static PokemonArchivos()
        {
            rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            nombreCarpeta = @"/Listados Pokemon";
            rutaEscritorioYCarpeta = rutaEscritorio + nombreCarpeta;
        }

        /// <summary>
        /// Guarda un archivo en formato json con la lista de pokemon alojados.
        /// </summary>
        /// <param name="datos">La lista que se serializará en formato json</param>
        public static void EscribirJsonLista(List<Pokemon> datos)
        {
            try
            {
                string nombreArchivo = @"/Listado de Pokemon en el Centro.json";
                string rutaCompleta = rutaEscritorioYCarpeta + nombreArchivo;

                if (!Directory.Exists(rutaEscritorioYCarpeta))
                {
                    Directory.CreateDirectory(rutaEscritorioYCarpeta);
                }

                using (StreamWriter writer = new StreamWriter(rutaCompleta))
                {
                    JsonSerializerOptions opc = new JsonSerializerOptions();
                    opc.WriteIndented = true;
                    string jsonString = JsonSerializer.Serialize(datos, opc);
                    writer.WriteLine(jsonString);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar archivo json.", ex);
            }
        }

        /// <summary>
        /// Deserializa un archivo json.
        /// </summary>
        /// <returns>Retorna lo deserializado en tipo lista</returns>
        public static List<Pokemon> LeerJson()
        {
            try
            {
                string rutaCompleta = rutaEscritorioYCarpeta + @"/Listado de Pokemon en el Centro.json";
                List<Pokemon> datos;

                if (Directory.Exists(rutaEscritorioYCarpeta))
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {

                        string archivoJson = File.ReadAllText(rutaCompleta);
                        datos = JsonSerializer.Deserialize<List<Pokemon>>(archivoJson);

                        return datos;
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar leer archivo json.", ex);
            }
        }

        /// <summary>
        /// Método que creará un archivo xml con el listado de pokemon alojados en el centro.
        /// </summary>
        public static void EscribirXml(List<Pokemon> pokemon)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar archivo xml.", ex);
            }
        }

        /// <summary>
        /// Método que leerá un archivo, y lo mostrará en el RichTextBox.
        /// </summary>
        /// <returns>Retorna una lista pokemon</returns>
        public static List<Pokemon> LeerXml()
        {
            try
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
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar leer archivo xml.", ex);
            }
        }

        /// <summary>
        /// Método que creará un archivo txt con el listado de pokemon alojados en el centro.
        /// </summary>
        public static void EscribirTxt()
        {
            try
            {
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
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar archivo txt.", ex);
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
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar leer archivo txt.", ex);
            }
        }
    }
}
