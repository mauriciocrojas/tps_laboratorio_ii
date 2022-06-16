﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pokemon : IDatos
    {
        public string nombre;
        public string tipo;
        public int id;
        public string ataquePrincipal;
        public int danio;
        public static List<Pokemon> listaPokemon = new List<Pokemon>();

        /// <summary>
        /// Constructor estático que instancia y hardcodea la lista. 
        /// </summary>
        static Pokemon()
        {
            listaPokemon = new List<Pokemon>();
            HardcodearPokemon();
        }

        public Pokemon() { }

        /// <summary>
        /// Constructor de instancia que recibe parámetros del pokemon.
        /// </summary>
        /// <param name="nombre">Nombre del pokemon</param>
        /// <param name="tipo">Tipo del pokemon</param>
        /// <param name="id">Id  del pokemon</param>
        /// <param name="ataquePrincipal">Ataque principal del pokemon</param>
        public Pokemon(string nombre, string tipo, int id, string ataquePrincipal, int danio)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.id = id;
            this.ataquePrincipal = ataquePrincipal;
            this.danio = danio;
        }

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
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pokemon pokemon in listaPokemon)
            {
                sb.AppendLine($"{pokemon.MostrarDato()}");
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
        /// <returns>Retorna true en caso de agregar a la lista, false caso contrario</returns>
        public static bool AgregarPokemonManual(string nombre, string tipo, int id, string ataque, int danio)
        {
            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(tipo) || String.IsNullOrEmpty(ataque) 
                || String.IsNullOrEmpty(id.ToString()) || String.IsNullOrEmpty(danio.ToString()))
            {
                return false;
            }
            Pokemon pokemon = new Pokemon(nombre, tipo, id, ataque, danio);
            listaPokemon.Add(pokemon);
            return true;
        }
    }
}