using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Evolutions>> pokemonData =
             new Dictionary<string, List<Evolutions>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                string[] inputTokens = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens.Length == 1)
                {
                    string pokemonName = inputTokens[0];
                    if (pokemonData.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (Evolutions evolution in pokemonData[pokemonName])
                        {
                            Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                        }
                    }
                }
                else
                {
                    string pokemonName = inputTokens[0];
                    string evolutionType = inputTokens[1];
                    int evolutionIndex = int.Parse(inputTokens[2]);
                    if (!pokemonData.ContainsKey(pokemonName))
                    {
                        pokemonData.Add(pokemonName, new List<Evolutions>());
                    }
                    pokemonData[pokemonName].Add(new Evolutions(evolutionType, evolutionIndex));
                }
            }
            foreach (KeyValuePair<string,List<Evolutions>> pokemon in pokemonData)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (Evolutions evo in pokemon.Value.OrderByDescending(x=>x.EvolutionIndex))
                {
                    Console.WriteLine($"{evo.EvolutionType} <-> {evo.EvolutionIndex}");
                }
            }
        }
    }
    class Evolutions
    {
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
        public Evolutions(string evolutionType, int evolutionIndex)
        {
            this.EvolutionType = evolutionType;
            this.EvolutionIndex = evolutionIndex;
        }
    }
}
