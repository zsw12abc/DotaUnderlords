using System;

namespace Underlords.Model.Races
{
    public class Warrior : Underlord
    {
        public Warrior()
        {
            Description = "Gain Armor";
            LevelUpdateNumber = 3;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Gain +10 Armor
                    break;
                case 2:
                    //Gain +15 Armor
                    break;
                case 3:
                    //Gain +25 Armor
                    break;
            }

            throw new NotImplementedException();
        }
    }
}