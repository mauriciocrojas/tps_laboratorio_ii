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

        /// <summary>
        /// Función que retornará una lista de pokemon, siempre y cuando la capacidad 
        /// del Centro sea mayor o igual a la cantidad de pokemon de la lista.
        /// Caso contrario, invocará el delegado cupoLleno.
        /// </summary>
        /// <returns>La lista auxiliar de Pokemon</returns>
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