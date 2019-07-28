using System;
using System.Collections.Generic;
using System.Text;
using Underlords.Model;
using Underlords.Model.Races;

namespace Underlords.Models.ChessBoard
{
    public class Player : IPlayer
    {
        public List<Chess> Bench;
        public int CurrentExp;
        public int CurrentLife;
        public int InitialLife;
        public int Level;
        public int Money;
        public Chess[,] PlayerBoard;
        public List<Underlord> UnderlordGroup;

        public Player()
        {
            InitialLife = 100;
            CurrentLife = InitialLife;
            Level = 1;
            CurrentExp = 0;
            Money = 0;
            PlayerBoard = new Chess[4, 8];
            Bench = new List<Chess>();
        }


        public void SwitchHero(Position fromPosition, Position toPosition)
        {
            if (PlayerBoard[toPosition.x, toPosition.y] == null)
            {
                var hero = PlayerBoard[fromPosition.x, fromPosition.y];
                hero.Position = toPosition;
                PlayerBoard[fromPosition.x, fromPosition.y] = null;
                PlayerBoard[toPosition.x, toPosition.y] = hero;
            }
            else
            {
                var fromHero = PlayerBoard[fromPosition.x, fromPosition.y];
                var toHero = PlayerBoard[toPosition.x, toPosition.y];
                fromHero.Position = toPosition;
                toHero.Position = fromPosition;
                PlayerBoard[fromPosition.x, fromPosition.y] = toHero;
                PlayerBoard[toPosition.x, toPosition.y] = fromHero;
            }
        }

        public void DisplayBench()
        {
            var benchInformation = new StringBuilder();
            for (var i = 0; i < Bench.Count; i++)
                if (Bench[i] != null)
                    benchInformation.AppendLine($"Bench Slot {i} is {Bench[i].Name}");
                else
                    benchInformation.AppendLine($"Bench Slot {i} is Empty");

            Console.WriteLine(benchInformation.ToString());
        }

        public void PickHeroFromBench(int index, Position position)
        {
            var hero = Bench[index];
            hero.Position = new Position(3 - position.x, position.y);
            PlayerBoard[3 - position.x, position.y] = hero;
            Bench[index] = null;
        }

        public void BuyHero(int index, List<Hero> Shop)
        {
            if (Shop[index] != null)
            {
                if (Bench.Count < 8) Bench.Add(Shop[index]);
                Console.WriteLine($"Buy Hero from Shop Slot {index} {Shop[index].Name}");
                Shop[index] = null;
            }
            else
            {
                Console.WriteLine($"This Shop Slot {index} is null");
            }
        }

        public bool Lose()
        {
            var IsLost = true;
            foreach (var chess in PlayerBoard)
                if (chess != null)
                    IsLost = chess.IsDead && IsLost;
            return IsLost;
        }

        public void Fight(Player enemy)
        {
            throw new NotImplementedException();
        }


        public void PrintPlayerBoard()
        {
            var playerBoard = new StringBuilder();
            var len = 0;
            foreach (var chess in PlayerBoard)
            {
                len++;
                if (chess == null)
                    playerBoard.Append("O");
                else
                    playerBoard.Append("*");

                if (len == 8)
                {
                    len = 0;
                    playerBoard.AppendLine();
                }
            }

            Console.WriteLine(playerBoard.ToString());
        }
    }
}