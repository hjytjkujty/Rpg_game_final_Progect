namespace RPG_Game
{
    public interface IEquippabe
    {
        string Name { get; }
        void Equip(Player player);
        void Enequip(Player player);
    }
}
