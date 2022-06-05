using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PokemonTest
    {
        [TestMethod]
        public void ProbarCargaDeDatosManualNuevoPokemon()
        {

            //Act
            bool resultado = Pokemon.AgregarPokemon("Chikorita", "Planta", "152", "Látigo Cepa");

            //Assert
            Assert.IsTrue(resultado);
        }
    }
}
