using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn08Sep2018.SportsV1
{
    public class TeamScore:Team
    {
        internal int TeamTotalScore;
         internal bool IsWinner = false;
        
       internal PlayerScore[] PS = new PlayerScore[11];
       
       // public int TeamTotalScore=0;


        protected internal int PScoreCount = 0;
        public void SetTeamScore(Team T)
        {

            Console.WriteLine("enter score of team");


            for (PScoreCount = 0; PScoreCount < StaticVariables.PlayerScoreSize; PScoreCount++)
            {

                PS[PScoreCount] = new PlayerScore();
                PS[PScoreCount].PlayerObj = T.Players[PScoreCount];

                Console.WriteLine("enter the score of the player:{0}", PScoreCount + 1);
                PS[PScoreCount].PScore = int.Parse(Console.ReadLine());

                Console.WriteLine("enter no. of balls:{0}", PScoreCount + 1);
                PS[PScoreCount].Balls = int.Parse(Console.ReadLine());

                PS[PScoreCount].PlayerObj.StrikeRate= (PS[PScoreCount].PScore / PS[PScoreCount].Balls) * 100;

              
                Console.WriteLine("strike rate of the player is"+ PS[PScoreCount].PlayerObj.StrikeRate);

                TeamTotalScore = TeamTotalScore + PS[PScoreCount].PScore;
                
            }
            
 

        Console.WriteLine("team total score is" + TeamTotalScore);
                
                
           


        }
    }
}
