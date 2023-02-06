using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pokemon;

namespace UnitTestPokemon
{
    [TestClass]
    public class UnitTestPokemon
    {
        [TestMethod]
        public void TestPokemonObject()
        {
            // Arrange
            string PokemonName = "pikachu";
            string PokemonType = "electric";
            string PokemonDesc = "Likes to relax";

            // Act
            PokemonC pokemon = new PokemonC();
            var Pok = pokemon.Get("pikachu");

            // Assert
            string name = Pok.Name;
            string typ  = Pok.type;
            string desc = Pok.Description;

            Assert.AreEqual(PokemonName, name);
            //Assert.AreEqual(PokemonDesc, desc);
            Assert.AreEqual(PokemonType, typ);

        }
    }
}
