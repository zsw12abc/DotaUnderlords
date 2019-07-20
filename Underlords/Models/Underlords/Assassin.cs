using System;

namespace Underlords.Model.Races
{
    public class Assassin : Underlord
    {
        public Assassin()
        {
            Name = GetType().Name;
            Description = "Get Critical Hit";
            LevelUpdateNumber = 3;
//            Level = count / LevelUpdateNumber;
        }

        protected override object GetEffect(int level)
        {
            switch (level)
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