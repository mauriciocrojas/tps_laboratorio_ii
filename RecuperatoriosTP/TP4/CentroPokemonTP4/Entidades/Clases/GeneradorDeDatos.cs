using Entidades;
using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public static class GeneradorDeDatos
    {
        static Random rnd;
        static List<Pokemon> auxListPokemon = Pokemon.ListaPokemon;

        static GeneradorDeDatos()
        {
            rnd = new Random();        
        }

        public static Random Rnd { get => rnd; }


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
