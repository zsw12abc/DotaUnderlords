namespace Underlords.Model.Races
{
    public abstract class Underlord : IUnderlord
    {
        public Underlord()
        {
            Name = GetType().Name;
        }

        public string Name { get; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int LevelUpdateNumber { get; set; }

        public abstract object GetEffect(int count);
    }
}