using Domain;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastleRemastered.MonsterFactory
{
    public class MonsterFactory
    {
        public static Monster CreateMonster(MonsterType monsterType)
        {
            switch (monsterType)
            {
                case MonsterType.Dragon:
                    return new Monster(monsterType, 45, 30, 150, 110);
                case MonsterType.Zombie:
                    return new Monster(monsterType, 25, 20, 50, 100);
                case MonsterType.Skeleton:
                    return new Monster(monsterType, 30, 25, 75, 95);
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
