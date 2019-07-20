using System;

namespace Underlords.Model.Races
{
    public class Mage : Underlord
    {
        public Mage()
        {
            Description = "Suffer Magic Resistance";
            LevelUpdateNumber = 3;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Suffer -40% Magic Resistance
                    break;
                case 2:
                    //Suffer -100% Magic Resistance
                    break;
            }

            throw new NotImplementedException();
        }
    }
}