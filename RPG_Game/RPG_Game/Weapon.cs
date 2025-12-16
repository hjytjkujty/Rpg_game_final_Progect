namespace RPG_Game
{
    public class Weapon : Item, IEquippable
    {

        public int Damage { get; protected set; }

        public Weapon(string name, string desscription, int damage) : base(name, desscription)
        {
            Damage = damage;
        }

        public void Enequip(Player player)
        {
            Console.WriteLine($"{Name} екіпіровано! (+{Damage} до атаки)");
        }

        public void Equip(Player player)
        {
            Console.WriteLine($"{Name} знято.");
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} екіпірує {Name}!");
            Equip(player);
        }
    }
}
