namespace PokemonSimulator
{
    public class Charizard : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Charizard(string name, int health)
        {
            Name = name;
            Health = health;
        }

        private int Firebolt()
        {
            return 84;
        }

        public void Attack(IPokemon pokemon)
        {
            pokemon.LooseHealth(Firebolt());
        }

        public void LooseHealth(int damage)
        {
            Health = Health - damage;
        }
    }
}
