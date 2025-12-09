namespace RPG_Game
{
    public interface IEquippabe
    {
        string Name { get; }
        void Equip();
        void Enequip();
    }

    public class Player
    {

    }
    
    public abstract class Enemy : Character
    {
        private int _axperienceReward;
        private List<Item> _loot;

        public int ExperienceReward
        {
            get => _axperienceReward;
            protected set => _axperienceReward = value;
        }

        protected Enemy(string name, int helth, int strengh) : base(name, helth, strengh)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
