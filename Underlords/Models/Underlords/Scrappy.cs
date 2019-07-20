using System;

namespace Underlords.Model.Races
{
    public class Scrappy : Underlord
    {
        public Scrappy()
        {
            Description = "Gain Armor and HP Regeneration";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Random Scrappy Gain +9 Armor and +8 HP Regeneration, if current units number is less, double the buffer;
                    break;
                case 2:
                    //All Scrappy Gain +9 Armor and +8 HP Regeneration, if current units number is less, double the buffer;
                    break;
                case 3:
                    //All Allies Gain +9 Armor and +8 HP Regeneration, if current units number is less, double the buffer;
                    break;
            }

            throw new NotImplementedException();
        }
    }
}