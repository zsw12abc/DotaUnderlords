using System;

namespace Underlords.Model.Races
{
    public class Dragon : Underlord
    {
        public Dragon()
        {
            Description = "Gain One More Skill";
            LevelUpdateNumber = 2;
        }

        public override object GetEffect(int count)
        {
            switch (count / LevelUpdateNumber)
            {
                case 1:
                    //Gain One More Skill
                    break;
            }

            throw new NotImplementedException();
        }
    }
}