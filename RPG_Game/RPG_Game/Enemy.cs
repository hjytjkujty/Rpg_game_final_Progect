namespace RPG_Game
{
    public abstract class Enemy : Character
    {
        private int _experienceReward;
        private List<Item> _loot;

        public int ExperienceReward
        {
            get => _experienceReward;
            protected set => _experienceReward = value;
        }

        protected Enemy(string name, int helth, int strengh, int ExperienceReward) : base(name, helth, strengh)
        {
            _experienceReward = ExperienceReward;
            _loot = new List<Item>();
        }

        protected void AddLoot(Item item)
        {
            _loot.Add(item);
        }

        public List<Item> GetLoot()
        {
            return new List<Item>(_loot);
        }
    }
}
