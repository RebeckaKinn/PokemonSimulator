namespace PokemonSimulator
{
    public class Machamp : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Machamp(string name, int health)
        {
            Name = name;
            Health = health;
        }

        private int Punch()
        {
            return 130;
        }

        public void Attack(IPokemon pokemon)
        {
            pokemon.LooseHealth(Punch());
        }

        public void LooseHealth(int damage)
        {
            Health = Health - damage;
        }
    }
}
