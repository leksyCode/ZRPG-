using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDuel
{
    class Warrior : Player
    {
        public override int HealthPoints { get; set; }
        public override int AttackPoints { get; set; }
        public override int ArmorPoints { get; set; }
        public override string Ability { get; set; }
        bool abilityUsed = false;

        public Warrior(int HealthPoints, int AttackPoints, int ArmorPoints)
        {
            this.HealthPoints = HealthPoints;
            this.AttackPoints = AttackPoints;
            this.ArmorPoints = ArmorPoints;
        }

        Random rand = new Random();

        public override int Attack(Player p)
        {
            int randomChance = rand.Next(80, 120);
            int damage = Convert.ToInt32((AttackPoints * randomChance) / 100);
            damage = damage - p.Protect(damage);
            return damage;
        }

        public override int Protect(int damage)
        {
            int randomChance = rand.Next(80, 120);
            return Convert.ToInt32((ArmorPoints * randomChance) / 100);
        }

        public override bool IsAlive()
        {
            if (HealthPoints <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string IsAbilityUsed()
        {
            if (abilityUsed == true)
            {
                return Ability;
            }
            return null;
        }
    }
}


