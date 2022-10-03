using Domain.Enum;
using KeyCastleRemastered.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Player :IFightable
    {
        public Player(string name, PlayerClass playerClass, PlayerRace playerRace, double maxHealth, int minDamage, int maxDamage, int totalLife)
        {
            Name = name;
            PlayerClass = playerClass;
            PlayerRace = playerRace;
            MaxHealth = maxHealth;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            TotalLife = totalLife;       
        }
        public PlayerClass PlayerClass { get; set; } // when using an enum the Name of the class will be the DataType
        public PlayerRace PlayerRace { get; set; }
        public double ExperiencePoints { get; set; }
        public double MaxHealth { get; set; }
        public double TotalLife { get; set; }
        public double GoldHeld { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public string Location { get; set; }

        //______________________________________________________________ 
        public string Name { get; set; }
        public bool HasKey { get; set; }
        public int MaxDefend { get; set; }
        public int MinDefend { get; set; }

        private readonly Random random = new Random();
        
        public int GenerateAttackAmount()
        {
            return random.Next(MinDamage, MaxDamage);
        }

        public int GenerateDefenseAmount()
        {
            return random.Next(MinDefend,MaxDefend);
        }

    }
}
