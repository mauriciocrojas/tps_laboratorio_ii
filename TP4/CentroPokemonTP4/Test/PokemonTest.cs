using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PokemonTest
    {
        //Pruebo m�todo Carga de datos manual(AgregarPokemonManual)
        [TestMethod]
        public void ProbarCargaDeDatosManualNuevoPokemon()
        {

            //Act
            bool resultado = Pokemon.AgregarPokemonManual("Chikorita", "Planta", "152", "L�tigo Cepa");

            //Assert
            Assert.IsTrue(resultado);
        }

        //Pruebo m�todo de extensi�n(LanzarAtaque)
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
