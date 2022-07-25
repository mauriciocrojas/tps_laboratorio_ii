using Entidades;
using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class GeneradorDeDatos
    {
        static Random rnd;
        static List<Pokemon> auxListPokemon;

        static GeneradorDeDatos()
        {
            rnd = new Random();
            auxListPokemon = Pokemon.ListaPokemon;
        }

        public static Random Rnd { get => rnd; }

        /// <summary>
        /// Propiedad que devolverá un pokemon aleatorio de la lista auxiliar, donde previamente se guardó la lista original de pokemon.
        /// </summary>
        public static Pokemon GetUnPokemon
        {
            get
            {
                Pokemon pokemon = auxListPokemon[rnd.Next(0, auxListPokemon.Count)];
                return pokemon;
            }
        }

    }
}
