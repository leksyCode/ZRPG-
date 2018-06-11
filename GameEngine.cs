using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDuel
{
    public delegate void GameHitDelegate(Player p1, Player p2);

    public class GameEngine
    {

        public  static int PlayerOneHit(Player p1, Player p2)
        {
            p2.HealthPoints -= p1.Attack(p2);
            return p2.HealthPoints;
        }

        public static int PlayerTwoHit(Player p1, Player p2)
        {
            p1.HealthPoints -= p2.Attack(p1);
            return p1.HealthPoints;
        }
        
        public void PlayGame()
        {

        }
    }
}
