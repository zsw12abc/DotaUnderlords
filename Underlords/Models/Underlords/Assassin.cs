using System;

namespace Underlords.Model.Races
{
    public class Assassin : Underlord
    {
        public Assassin()
        {
            Description = "Get Critical Hit";
            LevelUpdateNumber = 3;
//            Level = count / LevelUpdateNumber;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //10% get 300% critical hit;
                    break;
                case 2:
                    //20% get 400% critical hit;
                    break;
                case 3:
                    //10% get 300% critical hit;
                    break;
            }

            throw new NotImplementedException();
        }
    }
}