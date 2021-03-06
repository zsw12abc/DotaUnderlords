using System;

namespace Underlords.Model.Races
{
    public class BloodBound : Underlord
    {
        public BloodBound()
        {
            Description = "Get Bounce Damage after other BloodBound died";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Get +100% Attack Damage
                    break;
            }

            throw new NotImplementedException();
        }
    }
}