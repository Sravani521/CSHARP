using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn08Sep2018.SportsV1
{
   public class Match
    {
        public TeamScore teamsc1 = new TeamScore();
        public TeamScore teamsc2 = new TeamScore();
       

      public void ResultDetails(Team team1,Team team2)
        {
            if(teamsc1.TeamTotalScore>teamsc2.TeamTotalScore)
            {
                Console.WriteLine("team 1 is the winner"+ teamsc1.TeamTotalScore);
                teamsc1.IsWinner = true;
            }
            else
            {
                Console.WriteLine("team 2 is the winner"+ teamsc2.TeamTotalScore);
                teamsc2.IsWinner = true;
            }

                  
        }
        public void ManOfTheMatch()
        {
            if (teamsc1.IsWinner == true)
            {
                teamsc1.PS[0].PlayerObj.HighestScore = teamsc1.PS[0].PScore;
                for (int HScore = 0; HScore < StaticVariables.PlayerSize; HScore++)
                {
                    if (teamsc1.PS[0].PlayerObj.HighestScore < teamsc1.PS[HScore].PScore)
                    {
                        teamsc1.PS[0].PlayerObj.HighestScore = teamsc1.PS[HScore].PScore;
                        teamsc1.PS[0].PlayerObj.Name = teamsc1.PS[HScore].PlayerObj.Name;
                    }

                }
                Console.WriteLine("man of the match is" + teamsc1.PS[0].PlayerObj.HighestScore + " " + teamsc1.PS[0].PlayerObj.Name);
                
            }
            teamsc2.PS[0].PlayerObj.HighestScore = teamsc2.PS[0].PScore;

            if (teamsc2.IsWinner == true)
                {
                    for (int HScore = 0; HScore < StaticVariables.PlayerSize; HScore++)
                    {
                        if (teamsc2.PS[0].PlayerObj.HighestScore < teamsc2.PS[HScore].PScore)
                        {
                            teamsc2.PS[0].PlayerObj.HighestScore = teamsc2.PS[HScore].PScore;
                            teamsc2.PS[0].PlayerObj.Name = teamsc2.PS[HScore].PlayerObj.Name;
                        }

                    }
                    Console.WriteLine("man of the match is" + teamsc2.PS[0].PlayerObj.HighestScore + " " + teamsc2.PS[0].PlayerObj.Name);

                }
            
        }
        public void highestscorerdetails()
        {
            teamsc1.PS[0].PlayerObj.HighestScore = teamsc1.PS[0].PScore;
            for (int HScore = 0; HScore <StaticVariables.PlayerSize; HScore++)
            {
                if (teamsc1.PS[0].PlayerObj.HighestScore < teamsc1.PS[HScore].PScore)
                {
                    teamsc1.PS[0].PlayerObj.HighestScore = teamsc1.PS[HScore].PScore;
                    teamsc1.PS[0].PlayerObj.Name = teamsc1.PS[HScore].PlayerObj.Name;
                }
               
            }
            Console.WriteLine("highest score of team a is" + teamsc1.PS[0].PlayerObj.HighestScore + " " + teamsc1.PS[0].PlayerObj.Name);
            teamsc2.PS[0].PlayerObj.HighestScore = teamsc2.PS[0].PScore;
            for (int HScore = 0; HScore < StaticVariables.PlayerSize; HScore++)
            {
                if (teamsc2.PS[0].PlayerObj.HighestScore < teamsc2.PS[HScore].PScore)
                {
                    teamsc2.PS[0].PlayerObj.HighestScore = teamsc2.PS[HScore].PScore;
                    teamsc2.PS[0].PlayerObj.Name = teamsc2.PS[HScore].PlayerObj.Name;
                }
               
            }
            Console.WriteLine("highest score of team b is" + teamsc2.PS[0].PlayerObj.HighestScore + " " + teamsc2.PS[0].PlayerObj.Name);
        }
    }
}
