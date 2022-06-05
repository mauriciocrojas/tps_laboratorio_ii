namespace Entidades
{
    public static class Ataque
    {
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
