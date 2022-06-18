using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public static class PokemonAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;

        static PokemonAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=CentroPokemon;Integrated Security=True";
        }

    }
}
