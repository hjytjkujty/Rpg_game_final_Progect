namespace RPG_Game
{
    public class HealthPoition : Item
    {
        private int _healthAmount;

        public HealthPoition() : base("Зілля здоров'я", "Відновлює 40 HP")
        {
            _healthAmount = 40;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} викорриистовує {Name}");
            player.Heal(_healthAmount);
        }
    }
}
