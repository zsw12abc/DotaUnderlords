using System;

namespace Underlords.Model.Races
{
    public class Savage : Underlord
    {
        public Savage()
        {
            Description = "Gain Attack Damage";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Gain +10% Attack Damage
                    break;
                case 2:
                    //Gain +25% Attack Damage
                    break;
                case 3:
                    //Gain +45% Attack Damage
                    break;
            }

            throw new NotImplementedException();
        }
    }
}