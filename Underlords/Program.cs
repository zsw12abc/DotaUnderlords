using Underlords.Model;

namespace Underlords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var level = 1;
            var AntiMage = new AntiMage(level);
            var Razor = new Razor(level);
            AntiMage.ReleaseSkill(Razor);
        }
    }
}