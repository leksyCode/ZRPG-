using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDuel
{
    public abstract class Player
    {
        public abstract int HealthPoints { get; set; }
        public abstract int AttackPoints { get; set; }
        public abstract int ArmorPoints { get; set; }
        public abstract string Ability { get; set; }

        public Player() { }
        public abstract int Attack(Player p);
        public abstract int Protect(int dmg);
        public abstract string IsAbilityUsed();
        public abstract bool IsAlive();
    }
}
