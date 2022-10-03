using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHeroRepository
    {    //tasks that are empty of anything in their brackets is void. 
        Task<Player> GetPlayerByIDAsync (int id);//Tasks is a version of a method that allows the program to continue to run while its gatherign the info you want 

        Task<Player> UpdatePlayer(Player player);

        Task<bool> DeletePlayerByIDAsync (int id);

        Task<bool> CheckPlayerNameTaken (Player player);
    }
}
