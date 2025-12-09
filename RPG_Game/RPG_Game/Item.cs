namespace RPG_Game
{
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
}
