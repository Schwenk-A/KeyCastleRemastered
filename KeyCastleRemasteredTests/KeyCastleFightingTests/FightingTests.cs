using Domain;
using Domain.Enum;
using KeyCastleRemastered.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastleRemasteredTests.KeyCastleFightingTests
{
    internal class FightingTests
    {
        
        private static readonly IFightable[] _fightables = new[]
        {
            new Monster(MonsterType.Dragon, 45, 30, 150, 110),
            new Monster(MonsterType.Zombie, 25, 20, 50, 100),
            new Monster(MonsterType.Skeleton, 30, 25, 75, 95),
        };
    

        [Test]
        [TestCaseSource(nameof(_fightables))]
        public void Attack_given_IFightable_Should_Return_IntGreaterThanOrEqualTo_MinDamage(IFightable monster) 
        {
            var result = monster.GenerateAttackAmount();
            
            Assert.That(result, Is.GreaterThanOrEqualTo(monster.MinDamage));
        }





    }
}
