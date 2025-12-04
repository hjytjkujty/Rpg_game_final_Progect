namespace RPG_Game
{
    public interface IEquippabe
    {
        string Name { get; }
        void Equip();
        void Enequip();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
