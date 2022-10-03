using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constants
{
    public static class Messages
    {

       public const string Intro = "Welcome to the game - more will be added here later.";

        public static string UserAttack(Player p , Monster m, int damage)
        {
            return $"{p.Name} has dealt {damage} to {m.MonsterType} ";
        }

        public static string UserHealth(Player p)
        {
            return $"{p.Name} has {p.TotalLife} hit points out of {p.MaxHealth}";
        }

        public static string MonsterAttack(Monster m, Player p, int damage)
        {
            return $"{m.MonsterType} has dealt {damage} to {p.TotalLife}";
        }

        public static string MonsterHealth(Monster monster)
        {
            return $"{monster.MonsterType} has {monster.MonsterTotalLife} hit points out of {monster.MonsterMaxHealth}";
        }


    }
}
