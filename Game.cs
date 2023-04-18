namespace PokemonSimulator
{
    public class Game
    {
        public List<IPokemon> List;
        public Game(List<IPokemon> list)
        {
            List = list;
        }



        public void Play()
        {
            var macikarp = List[0];
            while (macikarp.Health > 0)
            {
                var newPokemon = GetWildPokemon();
                macikarp.Attack(newPokemon);
                Console.WriteLine($"{newPokemon.Name} har {newPokemon.Health} liv igjen.");
                newPokemon.Attack(macikarp);
                Console.WriteLine($"{macikarp.Name} har {macikarp.Health} liv igjen.\n");
            }
            Console.WriteLine($"\n{macikarp.Name} er sushi. RIP tiny useless fish.");
        }

        public IPokemon GetWildPokemon()
        {
            int randomIndex = new Random().Next(1, List.Count);
            return List[randomIndex];
        }
    }
}
