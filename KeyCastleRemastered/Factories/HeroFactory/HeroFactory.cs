using System;
using Domain.Enum;


namespace Domain.Hero
{
    public class HeroFactory
    {
       
        public static Player CreatePlayer(string name, PlayerClass playerClass, PlayerRace playerRace)
        {
            switch (playerClass)
            {
                case PlayerClass.Paladin:
                    return new Player(name, playerClass, playerRace, 110, 30, 45, 100);
                case PlayerClass.Warrior:
                    return new Player(name, playerClass, playerRace, 105, 45, 50, 100);
                case PlayerClass.Wizard:
                    return new Player(name, playerClass, playerRace, 95, 30, 55, 110);
                default:
                    throw new NotImplementedException();


            }
        }
    }
}
