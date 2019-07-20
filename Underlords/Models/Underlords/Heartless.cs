using System;

namespace Underlords.Model.Races
{
    public class Heartless : Underlord
    {
        public Heartless()
        {
            Description = "Reduce Armor";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //-5 Armor
                    break;
                case 2:
                    //-10 Armor
                    break;
                case 3:
                    //-15 Armor
                    break;
            }

            throw new NotImplementedException();
        }
    }
}