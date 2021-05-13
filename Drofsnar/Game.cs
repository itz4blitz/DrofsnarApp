using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar
{
    public class Game
    {
        public int TotalPoints { get; set; }
        public bool IsAlive { get; set; }
        public bool IsInvincible { get; set; }
        public int TotalLives { get; set; }
        public bool EarnedExtraLife { get; set; }

        public Game(int totalPoints, bool isAlive, bool isInvincible, int totalLives)
        {
            //refactor later to not let user supply invincible, etc. when initializing.
            IsAlive = isAlive;
            TotalPoints = totalPoints;
            TotalLives = totalLives;
            IsInvincible = isInvincible;
        }

        public void ExtraLifeEarned(Game currentGame)
        {
            if(currentGame.TotalPoints >= 10000)
            {
                currentGame.TotalLives++;
            }
        }

        public void MakePlayerInvincible()
        {
                IsInvincible = true;
        }

        public bool IsPlayerAlive()
        {
            if (TotalLives == 0)
            {
                IsAlive = false;
                return false;
            }
            else return true;
        }
    }
}
