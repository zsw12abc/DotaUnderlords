namespace Underlords.Model.Races
{
    public class Underlord
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int LevelUpdateNumber { get; set; }
        public object Effect { get; set; }
    }
}