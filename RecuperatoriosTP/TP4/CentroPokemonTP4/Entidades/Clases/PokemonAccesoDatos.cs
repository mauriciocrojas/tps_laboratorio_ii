using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades.Clases
{
    public static class PokemonAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PokemonAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=CentroPokemon;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Pokemon> Leer()
        {
            List<Pokemon> listaPokemon = new List<Pokemon>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM PokemonAlojados";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listaPokemon.Add(new Pokemon(dataReader["Nombre"].ToString(), dataReader["Tipo"].ToString(), Convert.ToInt32(dataReader["IDPokemon"]), dataReader["AtaquePrincipal"].ToString(), Convert.ToInt32(dataReader["Danio"])));
                    }
                }
                return listaPokemon;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Pokemon> LeerCurados()
        {
            List<Pokemon> listaPokemon = new List<Pokemon>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM PokemonAlojados WHERE danio = 0";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listaPokemon.Add(new Pokemon(dataReader["Nombre"].ToString(), dataReader["Tipo"].ToString(), Convert.ToInt32(dataReader["IDPokemon"]), dataReader["AtaquePrincipal"].ToString(), Convert.ToInt32(dataReader["Danio"])));
                    }
                }
                return listaPokemon;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                connection.Close();
            }
        }

        public static void GuardarPokemonEnBase(Pokemon pokemon)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO PokemonAlojados (IDPokemon, Nombre, Tipo, AtaquePrincipal, Danio)" +
                    $"VALUES ('{pokemon.id}', '{pokemon.nombre}', '{pokemon.tipo}', '{pokemon.ataquePrincipal}', '{pokemon.danio}')";

                command.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                connection.Close();
            }
        }

        public static void GuardarListaEnBase()
        {
            foreach (var pokemon in Pokemon.ListaPokemon)
            {
                GuardarPokemonEnBase(pokemon);
            }
        }

        public static void EliminarPokemon(string nombrePokemon)
        {
            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM PokemonAlojados WHERE Nombre = '{nombrePokemon}'";

                command.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool EliminarPokemonDeBase(string nombrePokemon)
        {
            try
            {
                List<Pokemon> auxListPokemon = Pokemon.ListaPokemon;

                foreach (var pokemon in auxListPokemon)
                {
                    if (pokemon.nombre == nombrePokemon)
                    {
                        EliminarPokemon(pokemon.nombre);
                        Pokemon.ListaPokemon.Remove(pokemon);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            return false;
        }
    }
}
