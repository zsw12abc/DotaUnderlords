using System.Collections.Generic;
using Underlords.Model;
using Underlords.Model.Races;

namespace Underlords.Models.ChessBoard
{
    public class Player
    {
        public List<Chess> Bench;
        public Chess[,] ChessBoard;
        public int CurrentExp;
        public int CurrentLife;
        public int InitialLife;
        public int Level;
        public int Money;
        public List<Underlord> UnderlordGroup;

        public Player()
        {
            InitialLife = 100;
            CurrentLife = InitialLife;
            Level = 1;
            CurrentExp = 0;
            Money = 0;
            ChessBoard = new Chess[8, 8];
            Bench = new List<Chess>();
        }


        public void BuyHero(Hero hero)
        {
            if (Bench.Count < 8) Bench.Add(hero);
        }

        public void MoveHero(Hero hero, Position position)
        {
            if (ChessBoard[position.x, position.y] == null)
            {
                hero.Position = position;
                ChessBoard[position.x, position.y] = hero;
            }
            else
            {
                var heroReplace = ChessBoard[position.x, position.y];
                heroReplace.Position = hero.Position;
                ChessBoard[position.x, position.y] = hero;
                hero.Position = position;
            }
        }
    }
}