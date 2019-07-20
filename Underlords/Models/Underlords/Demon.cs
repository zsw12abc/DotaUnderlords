using System;

namespace Underlords.Model.Races
{
    public class Demon : Underlord
    {
        public Demon()
        {
            Description = "Gain Pure Damage";
            LevelUpdateNumber = 1;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Get 50% Pure Damage
                    break;
            }

            throw new NotImplementedException();
        }
    }
}