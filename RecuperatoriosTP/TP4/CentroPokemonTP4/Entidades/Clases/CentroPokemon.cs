using System;
using System.Collections.Generic;

namespace Entidades
{
    public class CentroPokemon
    {
        static List<Pokemon> auxlistaPokemon;
        int capacidad;
        static Random rnd;


        public event Action<bool> cupoLleno;

        public CentroPokemon(int cupo)
        {
            this.capacidad = cupo;
            rnd = new Random();
            auxlistaPokemon = new List<Pokemon>();
        }

        public List<Pokemon> TraerPokemon()
        {

            if (auxlistaPokemon.Count <= capacidad)
            {

                auxlistaPokemon.Add(Pokemon.ListaPokemon[rnd.Next(0, Pokemon.ListaPokemon.Count)]);

            }
            else
            {
                cupoLleno.Invoke(true);
            }

            return auxlistaPokemon;

        }
    }
}