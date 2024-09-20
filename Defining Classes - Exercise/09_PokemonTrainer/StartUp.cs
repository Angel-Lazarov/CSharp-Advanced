
namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main()
        {

            Dictionary<string, Trainer> trainers = new();

            string trainerInfoInput = string.Empty;
            while ((trainerInfoInput = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = trainerInfoInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerInfo[0];
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

                Pokemon pokemon = new(trainerInfo[1], trainerInfo[2], int.Parse(trainerInfo[3]));

                Trainer trainer = new(trainerName, pokemon);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].AddPokemon(pokemon);
                }

            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Fire":

                        foreach (KeyValuePair<string, Trainer> trainer in trainers)
                        {
                            if (trainer.Value.Pokemons.Any(p => p.Element == "Fire"))
                            {
                                trainer.Value.Badges++;
                            }
                            else
                            {
                                trainer.Value.DecreaseHealth();
                                //if (trainer.Value.Pokemons.Any(x => x.Health <= 0))
                                //{
                                trainer.Value.RemovePokemon();
                                //}
                            }
                        }

                        break;

                    case "Water":

                        foreach (KeyValuePair<string, Trainer> trainer in trainers)
                        {
                            if (trainer.Value.Pokemons.Any(p => p.Element == "Water"))
                            {
                                trainer.Value.Badges++;
                            }
                            else
                            {
                                trainer.Value.DecreaseHealth();
                                //if (trainer.Value.Pokemons.Any(x => x.Health <= 0))
                                //{
                                trainer.Value.RemovePokemon();
                                //}
                            }
                        }
                        break;

                    case "Electricity":
                        foreach (KeyValuePair<string, Trainer> trainer in trainers)
                        {
                            if (trainer.Value.Pokemons.Any(p => p.Element == "Electricity"))
                            {
                                trainer.Value.Badges++;
                            }
                            else
                            {
                                trainer.Value.DecreaseHealth();
                                //if (trainer.Value.Pokemons.Any(x => x.Health <= 0))
                                //{
                                trainer.Value.RemovePokemon();
                                //}
                            }
                        }
                        break;
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
