using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDuel
{
    class Knight : Player
    {
        public override int HealthPoints { get; set; }
        public override int AttackPoints { get; set; }
        public override int ArmorPoints { get; set; }
        public override string Ability { get; set; }
        bool abilityUsed = false;

        public Knight(int HealthPoints, int AttackPoints, int ArmorPoints)
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
            if (rand.Next(0, 100) <= 10)
            {
                abilityUsed = true;
                Ability = " Knight сriting";
                return damage * 2;
            }
            return damage;
        }

        public override int Protect(int dmg)
        {
            if (rand.Next(0, 100) <= 20)
            {
                abilityUsed = true;
                Ability = " Knight blocking";
                return dmg;
            }
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
