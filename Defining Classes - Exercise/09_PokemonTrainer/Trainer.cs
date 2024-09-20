
using System.Reflection;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, Pokemon pokemon)
        {
            Name = name;
            Badges = 0;

            Pokemons = new List<Pokemon> { pokemon };
        }

        public string Name { get; set; }
        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        //public void RemovePokemon()
        //{
        //    while (Pokemons.Any(x => x.Health <= 0))
        //    {
        //        foreach (var pokemon in Pokemons)
        //        {
        //            if (pokemon.Health <= 0)
        //            {
        //                Pokemons.Remove(pokemon);
        //                break;
        //            }
        //        }
        //    }
        //}
        public void RemovePokemon()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                if (Pokemons[i].Health <= 0)
                {
                    Pokemons.Remove(Pokemons[i]);
                }
            }

        }


        public void DecreaseHealth()
        {
            foreach (var pokemon in Pokemons)
            {
                pokemon.Health -= 10;
            }
        }
    }
}
