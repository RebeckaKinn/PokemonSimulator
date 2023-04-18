namespace PokemonSimulator
{
    public class Pikachu : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Pikachu(string name, int health)
        {
            Name = name;
            Health = health;
        }

        private int Thunderbolt()
        {
            return 55;
        }

        public void Attack(IPokemon pokemon)
        {
            pokemon.LooseHealth(Thunderbolt());
        }

        public void LooseHealth(int damage)
        {
            Health = Health - damage;
        }
    }
}
