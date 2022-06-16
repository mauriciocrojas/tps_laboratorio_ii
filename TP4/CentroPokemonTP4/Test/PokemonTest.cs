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
            bool resultado = Pokemon.AgregarPokemonManual("Chikorita", "Planta", 152, "Látigo Cepa", 33);

            //Assert
            Assert.IsTrue(resultado);
        }

        //Pruebo método de extensión(CurarPokemon)
        [TestMethod]
        public void ProbarCurarPokemon()
        {

            //Arrange
            string pokemon = "Charmander";
            string resultadoEsperado = "Charmander ha sido curado y su daño es 0";

            //Act
            string resultado = pokemon.CurarPokemon();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
