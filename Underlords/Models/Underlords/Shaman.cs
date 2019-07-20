using System;

namespace Underlords.Model.Races
{
    public class Shaman : Underlord
    {
        public Shaman()
        {
            Description = "Reduce Mana for Hexed, Stunned or Silenced Enemy";
            LevelUpdateNumber = 3;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Reduce -200% Mana for Hexed, Stunned or Silenced Enemy
                    break;
            }

            throw new NotImplementedException();
        }
    }
}