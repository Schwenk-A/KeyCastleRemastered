using Domain.Enum;
using KeyCastleRemastered.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Monster : IFightable
    {
        public Monster(MonsterType monsterType, int monsterMaxDamage, int monsterMinDamage, double monsterTotalLife, double monsterMaxHealth)
        {
            MonsterType = monsterType;
            MonsterTotalLife = monsterTotalLife;
            MonsterMaxHealth = monsterMaxHealth; 
            MinDamage = monsterMinDamage;
            MaxDamage = monsterMaxDamage;
        }
        public MonsterType MonsterType { get; set; }
        public double MonsterGoldHeld { get; set; }
        public bool IsMonsterDead { get; set; }
        //_______________________________________Above is Basic info__Below is Fighting info
    
        public double MonsterTotalLife { get; set; }
        public double MonsterMaxHealth { get; set; }
        public int MinDamage { get; set ; }
        public int MaxDamage { get ; set; }
        public int MaxDefend { get; set; }
        public int MinDefend { get; set; }

        private readonly Random random = new Random();

        public int GenerateAttackAmount()
        {
            return random.Next(MinDamage, MaxDamage);
        }

        public int GenerateDefenseAmount()
        {
            return random.Next(MinDefend, MaxDefend);
        }
    }
}
