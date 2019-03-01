using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    public class Liiga
    {
        public string TeamName { get; set; }
        public int PlayedGames { get; set; }
        public int Wins { get; set; }
        public int GoalDifference { get; set; }

        public Liiga(string teamname, int playgames, int wins, int goaldifference)
        {
            TeamName = teamname;
            PlayedGames = playgames;
            Wins = wins;
            GoalDifference = goaldifference;
        }

        public void AddWin()
        {
            Wins += 1;
        }

        public void UpdateGoalDifference(int goals)
        {
            GoalDifference += goals;
        }

       
    }
}
