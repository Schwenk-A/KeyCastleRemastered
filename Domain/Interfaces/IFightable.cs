using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCastleRemastered.Interfaces
{


    public interface IFightable
    {

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int MaxDefend { get; set; }
        public int MinDefend { get; set; }

        public int GenerateAttackAmount();

        public int GenerateDefenseAmount();
    }
}
