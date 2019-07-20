using System;

namespace Underlords.Model.Races
{
    public class Primordial : Underlord
    {
        public Primordial()
        {
            Description = "Disarm melee and ranged attackers for 4 seconds";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Primordial, 30% Disarm melee attackers and 10% disarm ranged attackers for 4s 
                    break;
                case 2:
                    //Allies, 30% Disarm melee attackers and 10% disarm ranged attackers for 4s 
                    break;
            }

            throw new NotImplementedException();
        }
    }
}