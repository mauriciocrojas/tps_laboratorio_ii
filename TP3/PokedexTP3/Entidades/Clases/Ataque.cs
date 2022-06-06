namespace Entidades
{
    public static class Ataque
    {
        /// <summary>
        /// Método de extensión que extiende un string (que será el nombre del pokemon de la lista).
        /// </summary>
        /// <param name="strpokemon">Nombre del pokemon seleccionado en la lista</param>
        /// <returns>Retorna el ataque</returns>
        public static string LanzarAtaque(this string strpokemon)
        {
            foreach (Pokemon pokemon in Pokemon.listaPokemon)
            {
                if (strpokemon == pokemon.nombre)
                {
                    return $"{pokemon.nombre} ha lanzado {pokemon.ataquePrincipal}";
                }
            }
            return "No se encontró el pokemon";
        }
    }
}
