using System.Collections.Generic;
using Underlords.Model.Races;
using Underlords.Models;
using Underlords.Models.ChessBoard;

namespace Underlords.Model
{
    public class Axe : Hero
    {
        public Axe(int currentLevel) : base(currentLevel)
        {
            Cost = 1;
            Armor = 5;
            MaxMana = 50;
            MaxHP = 700 * currentLevel;
            AttackRange = 1;
            MoveSpeed = 295;
            MagicResistance = 0;
            Underlords = new List<Underlord> {new Warrior(), new Brawny()};
//            Skills  = new List<Skill>(){new BerserkersCall()};
            HpRegSpeed = 0;
            AttackSpeed = 1.5;
            switch (currentLevel)
            {
                case 1:
                    DPS = 35;
                    MinAttackDamage = 50;
                    MaxAttackDamage = 55;
                    break;
                case 2:
                    DPS = 70;
                    MinAttackDamage = 100;
                    MaxAttackDamage = 110;
                    break;
                case 3:
                    DPS = 140;
                    MinAttackDamage = 200;
                    MaxAttackDamage = 220;
                    break;
            }

            initialize();
        }

        public override void ReleaseSkill(Chess target)
        {
            Taunt(Position);
        }

        public void Taunt(Position position)
        {
            Armor += 15 + 10 * CurrentLevel;
            //To DO position. 
        }
    }
}