using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PokemonTest
    {
        //Pruebo método Carga de datos manual(AgregarPokemonManual)
        [TestMethod]
        public void ProbarCargaDeDatosManualNuevoPokemon()
        {

            //Act
            bool resultado = Pokemon.AgregarPokemonManual("Chikorita", "Planta", "152", "Látigo Cepa");

            //Assert
            Assert.IsTrue(resultado);
        }

        //Pruebo método de extensión(LanzarAtaque)
        [TestMethod]
        public void ProbarLanzadorDeAtaques()
        {

            //Arrange
            string pokemon = "Pikachu";
            string resultadoEsperado = "Charmander ha lanzado Lanzallamas";

            //Act
            string resultado = pokemon.LanzarAtaque();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
