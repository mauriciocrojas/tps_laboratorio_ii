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
            bool resultado = Pokemon.AgregarPokemonManual("Chikorita", "Planta", 152, "L�tigo Cepa", 33);

            //Assert
            Assert.IsTrue(resultado);
        }

        //Pruebo m�todo de extensi�n(CurarPokemon)
        [TestMethod]
        public void ProbarCurarPokemon()
        {

            //Arrange
            string pokemon = "Charmander";
            string resultadoEsperado = "Charmander ha sido curado y su da�o es 0";

            //Act
            string resultado = pokemon.CurarPokemon();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
