namespace Entidades
{
    public static class Salud
    {
        /// <summary>
        /// Método de extensión que extiende un string (que será el nombre del pokemon de la lista) y le cura los daños.
        /// </summary>
        /// <param name="strpokemon">Nombre del pokemon seleccionado en la lista</param>
        /// <returns>Retorna el ataque</returns>
        public static string CurarPokemon(this string strpokemon)
        {
            foreach (Pokemon pokemon in Pokemon.listaPokemon)
            {
                if (strpokemon == pokemon.nombre)
                {
                    pokemon.danio = 0;
                    return $"{pokemon.nombre} ha sido curado y su daño es 0";
                }
            }
            return "No se encontró el pokemon";
        }
    }
}
