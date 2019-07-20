using System;

namespace Underlords.Model.Races
{
    public class Inventor : Underlord
    {
        public Inventor()
        {
            Description = "Gain HP Regeneration";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //+15 HP Regenration
                    break;
                case 2:
                    //+40 HP Regenration
                    break;
            }

            throw new NotImplementedException();
        }
    }
}