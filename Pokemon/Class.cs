// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse)
// ;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pokemon
{
    public class Ability
    {
        [JsonProperty("ability")]
        public Ability ability;

        [JsonProperty("is_hidden")]
        public bool is_hidden;

        [JsonProperty("slot")]
        public int slot;
    }

    public class Ability2
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class Animated
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_female")]
        public string back_female;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_female")]
        public string back_shiny_female;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class BlackWhite
    {
        [JsonProperty("animated")]
        public Animated animated;

        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_female")]
        public string back_female;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_female")]
        public string back_shiny_female;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class Crystal
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_transparent")]
        public string back_shiny_transparent;

        [JsonProperty("back_transparent")]
        public string back_transparent;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_transparent")]
        public string front_shiny_transparent;

        [JsonProperty("front_transparent")]
        public string front_transparent;
    }

    public class DiamondPearl
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_female")]
        public string back_female;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_female")]
        public string back_shiny_female;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class DreamWorld
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public object front_female;
    }

    public class Emerald
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;
    }

    public class FireredLeafgreen
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;
    }

    public class Form
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class GameIndex
    {
        [JsonProperty("game_index")]
        public int game_index;

        [JsonProperty("version")]
        public Version version;
    }

    public class GenerationI
    {
        [JsonProperty("red-blue")]
        public RedBlue redblue;

        [JsonProperty("yellow")]
        public Yellow yellow;
    }

    public class GenerationIi
    {
        [JsonProperty("crystal")]
        public Crystal crystal;

        [JsonProperty("gold")]
        public Gold gold;

        [JsonProperty("silver")]
        public Silver silver;
    }

    public class GenerationIii
    {
        [JsonProperty("emerald")]
        public Emerald emerald;

        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen;

        [JsonProperty("ruby-sapphire")]
        public RubySapphire rubysapphire;
    }

    public class GenerationIv
    {
        [JsonProperty("diamond-pearl")]
        public DiamondPearl diamondpearl;

        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilver heartgoldsoulsilver;

        [JsonProperty("platinum")]
        public Platinum platinum;
    }

    public class GenerationV
    {
        [JsonProperty("black-white")]
        public BlackWhite blackwhite;
    }

    public class GenerationVi
    {
        [JsonProperty("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire omegarubyalphasapphire;

        [JsonProperty("x-y")]
        public XY xy;
    }

    public class GenerationVii
    {
        [JsonProperty("icons")]
        public Icons icons;

        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultrasunultramoon;
    }

    public class GenerationViii
    {
        [JsonProperty("icons")]
        public Icons icons;
    }

    public class Gold
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_transparent")]
        public string front_transparent;
    }

    public class HeartgoldSoulsilver
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_female")]
        public string back_female;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_female")]
        public string back_shiny_female;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class HeldItem
    {
        [JsonProperty("item")]
        public Item item;

        [JsonProperty("version_details")]
        public List<VersionDetail> version_details;
    }

    public class Home
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class Icons
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public object front_female;
    }

    public class Item
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class Move
    {
        [JsonProperty("move")]
        public Move move;

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> version_group_details;
    }

    public class Move2
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class MoveLearnMethod
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;
    }

    public class OmegarubyAlphasapphire
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class Other
    {
        [JsonProperty("dream_world")]
        public DreamWorld dream_world;

        [JsonProperty("home")]
        public Home home;

        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork;
    }

    public class Platinum
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_female")]
        public string back_female;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_female")]
        public string back_shiny_female;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class RedBlue
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_gray")]
        public string back_gray;

        [JsonProperty("back_transparent")]
        public string back_transparent;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_gray")]
        public string front_gray;

        [JsonProperty("front_transparent")]
        public string front_transparent;
    }

    public class Root
    {
        [JsonProperty("abilities")]
        public List<Ability> abilities;

        [JsonProperty("base_experience")]
        public int base_experience;

        [JsonProperty("forms")]
        public List<Form> forms;

        [JsonProperty("game_indices")]
        public List<GameIndex> game_indices;

        [JsonProperty("height")]
        public int height;

        [JsonProperty("held_items")]
        public List<HeldItem> held_items;

        [JsonProperty("id")]
        public int id;

        [JsonProperty("is_default")]
        public bool is_default;

        [JsonProperty("location_area_encounters")]
        public string location_area_encounters;

        [JsonProperty("moves")]
        public List<Move> moves;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("order")]
        public int order;

        [JsonProperty("past_types")]
        public List<object> past_types;

        [JsonProperty("species")]
        public Species species;

        [JsonProperty("sprites")]
        public Sprites sprites;

        [JsonProperty("stats")]
        public List<Stat> stats;

        [JsonProperty("types")]
        public List<Type> types;

        [JsonProperty("weight")]
        public int weight;
    }

    public class RubySapphire
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;
    }

    public class Silver
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_transparent")]
        public string front_transparent;
    }

    public class Species
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class Sprites
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_female")]
        public string back_female;

        [JsonProperty("back_shiny")]
        public string back_shiny;

        [JsonProperty("back_shiny_female")]
        public string back_shiny_female;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;

        [JsonProperty("other")]
        public Other other;

        [JsonProperty("versions")]
        public Versions versions;
    }

    public class Stat
    {
        [JsonProperty("base_stat")]
        public int base_stat;

        [JsonProperty("effort")]
        public int effort;

        [JsonProperty("stat")]
        public Stat stat;
    }

    public class Stat2
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class Type
    {
        [JsonProperty("slot")]
        public int slot;

        [JsonProperty("type")]
        public Type2 type;
    }

    public class Type2
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class UltraSunUltraMoon
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class Version
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class VersionDetail
    {
        [JsonProperty("rarity")]
        public int rarity;

        [JsonProperty("version")]
        public Version version;
    }

    public class VersionGroup
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int level_learned_at;

        [JsonProperty("move_learn_method")]
        public MoveLearnMethod move_learn_method;

        [JsonProperty("version_group")]
        public VersionGroup version_group;
    }

    public class Versions
    {
        [JsonProperty("generation-i")]
        public GenerationI generationi;

        [JsonProperty("generation-ii")]
        public GenerationIi generationii;

        [JsonProperty("generation-iii")]
        public GenerationIii generationiii;

        [JsonProperty("generation-iv")]
        public GenerationIv generationiv;

        [JsonProperty("generation-v")]
        public GenerationV generationv;

        [JsonProperty("generation-vi")]
        public GenerationVi generationvi;

        [JsonProperty("generation-vii")]
        public GenerationVii generationvii;

        [JsonProperty("generation-viii")]
        public GenerationViii generationviii;
    }

    public class XY
    {
        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_female")]
        public string front_female;

        [JsonProperty("front_shiny")]
        public string front_shiny;

        [JsonProperty("front_shiny_female")]
        public string front_shiny_female;
    }

    public class Yellow
    {
        [JsonProperty("back_default")]
        public string back_default;

        [JsonProperty("back_gray")]
        public string back_gray;

        [JsonProperty("back_transparent")]
        public string back_transparent;

        [JsonProperty("front_default")]
        public string front_default;

        [JsonProperty("front_gray")]
        public string front_gray;

        [JsonProperty("front_transparent")]
        public string front_transparent;
    }



    public class Description
    {
        [JsonProperty("description")]
        public string description;

        [JsonProperty("language")]
        public Language language;
    }

    public class HighestStat
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class Language
    {
        [JsonProperty("name")]
        public string name;

        [JsonProperty("url")]
        public string url;
    }

    public class Rootcharacteristic
    {
        [JsonProperty("descriptions")]
        public List<Description> descriptions;

        [JsonProperty("gene_modulo")]
        public int gene_modulo;

        [JsonProperty("highest_stat")]
        public HighestStat highest_stat;

        [JsonProperty("id")]
        public int id;

        [JsonProperty("possible_values")]
        public List<int> possible_values;
    }





    public class PokemonEnt
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string type { get; set; }
    }

}
