using Domain;
using KeyCastleRemastered.Interfaces;
using System;

namespace KeyCastleRemastered.FightingMchanics
{
    internal class Fighting
    {
        private readonly Player _player;

        private readonly Monster _monster;

        private readonly Random random = new Random();
        public Fighting(Player player, Monster monster)
        {
           _player = player;
           _monster = monster;
        }


        public CommenceFighting(IFightable fighterOne, IFightable fighterTwo)
        {
            var cointoss = random.Next(1, 3);
            var coinTossWinner = cointoss == 1 ? fighterOne : fighterTwo;
            coinTossWinner.GenerateAttackAmount();
            

        }
    }
}
