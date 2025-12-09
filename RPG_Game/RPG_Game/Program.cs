namespace RPG_Game
{
    public interface IEquippabe
    {
        string Name { get; }
        void Equip(Player player);
        void Enequip(Player player);
    }

    public interface ISpellCast 
    {
        int Mana { get; }
        void CastSpell(Character target);
        void RestoreMana(int amount);
    }


    public class Player
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
