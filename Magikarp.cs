namespace PokemonSimulator
{
    public class Magikarp : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool isUseless { get; set; }

        public Magikarp(string name, int health)
        {
            Name = name;
            Health = health;
            isUseless = true;
        }

        private int Splash()
        {
            return 10;
        }

        public void Attack(IPokemon pokemon)
        {
            pokemon.LooseHealth(Splash());
        }

        public void LooseHealth(int damage)
        {
            Health = Health - damage;
        }

    }
}
