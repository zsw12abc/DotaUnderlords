using System;

namespace Underlords.Model.Races
{
    public class Scaled : Underlord
    {
        public Scaled()
        {
            Description = "Gain Magic Resistance";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Gain +30% Magic Resistance
                    break;
                case 2:
                    //Gain +50% Magic Resistance
                    break;
            }

            throw new NotImplementedException();
        }
    }
}