namespace RPG_Game
{
    public class Goblin : Enemy
    {
        public Goblin() : base("гоблін", 40, 8, 30)
        {
            AddLoot(new HealthPoition());
        }

        public override void Attack(Character target)
        {
            var damage = Strenght;
            Console.WriteLine($"{Name} б'є кінжалом і завдає {damage}");
            target.TakeDamage(damage);
        }
    }
}
