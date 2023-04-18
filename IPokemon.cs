namespace PokemonSimulator
{
    public interface IPokemon
    {
        int Health { get; set; }
        string Name { get; set; }
        void Attack(IPokemon pokemon);
        void LooseHealth(int damage);
    }
}
