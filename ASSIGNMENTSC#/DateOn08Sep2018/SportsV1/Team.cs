using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn08Sep2018.SportsV1
{
  public  class Team
    {
        private string Name { get; set; }
        internal Player[] Players = new Player[StaticVariables.PlayerSize];

        public  void SetTeamDetails()
        {

            Console.WriteLine("enter the team name");
                Name = Console.ReadLine();

                for (int PnameCount = 0; PnameCount < StaticVariables.PlayerSize; PnameCount++)
                {
                    Players[PnameCount] = new Player();
                    Console.WriteLine("enter player names");
                   Players[PnameCount].Name = Console.ReadLine();

                }
            
        }

    }
}
