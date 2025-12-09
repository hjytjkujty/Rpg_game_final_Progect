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

    public abstract class Item
    {
        public string Name { get; protected set; }
        public string Desscription { get; protected set; }

        protected Item(string name, string desscription)
        {
            Name = name;
            Desscription = desscription;
        }

        public abstract void Use(Player player);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
