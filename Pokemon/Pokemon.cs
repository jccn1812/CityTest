using Newtonsoft.Json;
using RestSharp;
using System;



namespace Pokemon
{
    public class PokemonC
    {
        /// <summary>
        /// Define endpoint variables to get Id, name, type and description attributes
        /// </summary>
        private string endPointPok  = "https://pokeapi.co/api/v2/pokemon/name/";
        private string endPChartic  = "https://pokeapi.co/api/v2/characteristic/id/";
       

        private PokemonEnt Pok = new PokemonEnt();

        /// <summary>
        /// Define Rest and Request variables 
        /// </summary>
        private RestClient client;
        private RestRequest request;



        /// <summary>
        /// Public method to get a Pokemon entity, by name
        /// 
        /// Input (parameter): Pokemon name (by example: Pikachu)
        /// </summary>
        public PokemonEnt Get(string pokemonName)
        {
            try
            {

                client = new RestClient(endPointPok.Replace("name",pokemonName));
                request = new RestRequest();

                dynamic response = client.Get(request);
                Root root = JsonConvert.DeserializeObject<Root>(response.Content);

                Pok.Id = root.id.ToString(); ;
                Pok.type = root.types[0].type.name.ToString();
                Pok.Name = root.name;
                Pok.Description = null;

                //this.GetDescription(root.id);

                return Pok; 
            }

            catch (Exception e) 
            {
                return null;
            }


        }

        /// <summary>
        /// Private void method to get Pokemon description from Characteristics endpoint.
        /// 
        /// </summary>
        private void GetDescription(int IdPokemon)
        {
            client = new RestClient(endPChartic.Replace("id", IdPokemon.ToString()));
            request = new RestRequest();
            dynamic response = client.Get(request);
            Rootcharacteristic Root = JsonConvert.DeserializeObject<Root>(response.Content);

            Pok.Description = Root.descriptions[0].description.ToString();  

        }



    }
}
