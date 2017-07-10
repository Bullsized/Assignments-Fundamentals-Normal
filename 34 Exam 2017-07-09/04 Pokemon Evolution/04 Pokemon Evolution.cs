using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonList = new List<Pokemon>();

            string inputLine = Console.ReadLine();

            while (inputLine != "wubbalubbadubdub")
            {
                string[] lineOfPokemons = inputLine
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (lineOfPokemons.Length == 1)
                {
                    int onlyOneName = 0;
                    foreach (var pokeName in pokemonList)
                    {
                        if (pokeName.Name == lineOfPokemons[0])
                        {
                            while (onlyOneName != 1)
                            {
                                Console.WriteLine($"# {pokeName.Name}");
                                onlyOneName++;
                            }
                            Console.WriteLine($"{pokeName.EvoType} <-> {pokeName.IndexEvo}");
                        }
                    }
                }
                else
                {
                    int indexOfThePokemon = int.Parse(lineOfPokemons[2]);

                    Pokemon currentPoke = new Pokemon()
                    {
                        Name = lineOfPokemons[0],
                        EvoType = lineOfPokemons[1],
                        IndexEvo = indexOfThePokemon
                    };

                    pokemonList.Add(currentPoke);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var poke01 in pokemonList.Select(x => x.Name).Distinct())
            {
                Console.WriteLine("# " + poke01);

                string pokeEquals = poke01;

                foreach (var pokeMafiot in pokemonList.OrderByDescending(x => x.IndexEvo))
                {
                    if (pokeMafiot.Name == pokeEquals)
                    {
                        Console.WriteLine($"{pokeMafiot.EvoType} <-> {pokeMafiot.IndexEvo}");
                    }
                }
            }
        }
    }

    class Pokemon
    {
        public string Name { get; set; }

        public string EvoType { get; set; }

        public int IndexEvo { get; set; }
    }
}