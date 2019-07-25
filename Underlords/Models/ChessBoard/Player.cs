using System;
using System.Collections.Generic;
using Underlords.Model;
using Underlords.Model.Races;

namespace Underlords.Models.ChessBoard
{
    public class Player : IPlayer
    {
        public List<Chess> Bench;
        public int CurrentExp;
        public int CurrentLife;
        public Chess[,] Gameboard;
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
            Gameboard = new Chess[4, 8];
            Bench = new List<Chess>();
        }


        public void BuyHero(int index, List<Hero> Shop)
        {
            if (Shop[index] != null)
            {
                if (Bench.Count < 8) Bench.Add(Shop[index]);
                Console.WriteLine($"Buy Sort {index} {Shop[index].Name}");
                Shop[index] = null;
                else
                {
                    Console.WriteLine($"This Sort {index} is null");
                }
            }

            bool Lose()
            {
                var IsLost = true;
                foreach (var chess in Gameboard)
                    if (chess != null)
                        IsLost = chess.IsDead && IsLost;
                return IsLost;
            }

            void Fight(Player enemy)
            {
                throw new NotImplementedException();
            }

            void PickHeroFromBench(int index, Position position)
            {
                var hero = Bench[index];
                hero.Position = position;
                Gameboard[position.x, position.y] = hero;
                Bench[index] = null;
            }

            void SwitchHero(Position fromPosition, Position toPosition)
            {
                if (Gameboard[toPosition.x, toPosition.y] == null)
                {
                    var hero = Gameboard[fromPosition.x, fromPosition.y];
                    hero.Position = toPosition;
                    Gameboard[fromPosition.x, fromPosition.y] = null;
                    Gameboard[toPosition.x, toPosition.y] = hero;
                }
                else
                {
                    var fromHero = Gameboard[fromPosition.x, fromPosition.y];
                    var toHero = Gameboard[toPosition.x, toPosition.y];
                    fromHero.Position = toPosition;
                    toHero.Position = fromPosition;
                    Gameboard[fromPosition.x, fromPosition.y] = toHero;
                    Gameboard[toPosition.x, toPosition.y] = fromHero;
                }
            }
        }
    }