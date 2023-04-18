namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPokemon> WildPokemon = new List<IPokemon>
            {
                new Magikarp("Magikarp", 100),
                new Pikachu("Pikachu", 35),
                new Machamp("Machamp", 90),
                new Charizard("Charizard", 78),
            };
            var game = new Game(WildPokemon);
            game.Play();
        }
    }
}