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

        public void PickHeroFromBench(int index, Position position)
        {
            var hero = Bench[index];
            hero.Position = position;
            ChessBoard[position.x, position.y] = hero;
            Bench[index] = null;
        }

        public void SwitchHero(Position fromPosition, Position toPosition)
        {
            if (ChessBoard[toPosition.x, toPosition.y] == null)
            {
                var hero = ChessBoard[fromPosition.x, fromPosition.y];
                hero.Position = toPosition;
                ChessBoard[fromPosition.x, fromPosition.y] = null;
                ChessBoard[toPosition.x, toPosition.y] = hero;
            }
            else
            {
                var fromHero = ChessBoard[fromPosition.x, fromPosition.y];
                var toHero = ChessBoard[toPosition.x, toPosition.y];
                fromHero.Position = toPosition;
                toHero.Position = fromPosition;
                ChessBoard[fromPosition.x, fromPosition.y] = toHero;
                ChessBoard[toPosition.x, toPosition.y] = fromHero;
            }
        }
    }
}