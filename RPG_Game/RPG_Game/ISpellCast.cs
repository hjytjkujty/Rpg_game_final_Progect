namespace RPG_Game
{
    public interface ISpellCast 
    {
        int Mana { get; }
        void CastSpell(Character target);
        void RestoreMana(int amount);
    }
}
