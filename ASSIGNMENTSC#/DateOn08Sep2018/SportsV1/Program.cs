using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn08Sep2018.SportsV1
{
    class Program
    {
        
       public static int[] temp1  = new int[2];
        public static int[] temp2 = new int[2];
       

        static void Main(string[] args)
        {
            Team team1 = new Team();
            team1.SetTeamDetails();

            Team team2 = new Team();
            team2.SetTeamDetails();

            
            Match matchone = new Match();
            matchone.teamsc1.SetTeamScore(team1);
            matchone.teamsc2.SetTeamScore(team2);
            matchone.ResultDetails(team1,team2);

            matchone.highestscorerdetails();
            matchone.ManOfTheMatch();


            Console.ReadLine();
        }
    }
}
