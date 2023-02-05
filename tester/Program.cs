using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Pokemon;

namespace tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre de un Pokemon");
            String pokemonName;
            pokemonName = Console.ReadLine();
            

            PokemonC pokemon = new PokemonC();
            var Pok =  pokemon.Get(pokemonName.Trim());
            Console.WriteLine("Id :" + Pok.Id);
            Console.WriteLine("Name :" + Pok.Name);
            Console.WriteLine("Description " + Pok.Description);
            Console.WriteLine("Type : " + Pok.type);

            Console.ReadKey();




        }
    }


    public class PokemonEnt
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string type { get; set; }
    }
}
