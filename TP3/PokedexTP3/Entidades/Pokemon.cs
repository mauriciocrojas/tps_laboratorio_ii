using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pokemon
    {
        public string nombre;
        public string tipo;
        public int id;
        public string ataquePrincipal;
        public static List<Pokemon> listaPokemon = new List<Pokemon>();

        static Pokemon()
        {
            listaPokemon = new List<Pokemon>();
            HardcodearPokemon();
        }

        public Pokemon(string nombre, string tipo, int id, string ataquePrincipal)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.id = id;
            this.ataquePrincipal = ataquePrincipal;
        }

        public static void HardcodearPokemon()
        {
            Pokemon Bulbasaur = new Pokemon("Bulbasaur", "Planta-Veneno", 001, "Hoja afilada");
            Pokemon Ivysaur = new Pokemon("Ivysaur", "Planta-Veneno", 002, "Síntesis");
            Pokemon Venusaur = new Pokemon("Venusaur", "Planta-Veneno", 003, "Rayo solar");
            Pokemon Charmander = new Pokemon("Charmander", "Fuego", 004, "Lanzallamas");
            Pokemon Charmeleon = new Pokemon("Charmeleon", "Fuego", 005, "Giro fuego");
            Pokemon Charizard = new Pokemon("Charizard", "Fuego-Volador", 006, "Furia dragón");
            Pokemon Squirtle = new Pokemon("Squirtle", "Agua", 007, "Pistola de agua");
            Pokemon Wartortle = new Pokemon("Wartortle", "Agua", 008, "Cabezazo");
            Pokemon Blastoise = new Pokemon("Blastoise", "Agua", 009, "Hidrobomba");

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

        public string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"ID: {id}\nNombre: {nombre}\nTipo: {tipo}\nAtaque principal: {ataquePrincipal}");

            return sb.ToString();
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pokemon pokemon in listaPokemon)
            {
                sb.AppendLine($"{pokemon.MostrarDato()}");
            }

            return sb.ToString();
        }
    }
}
