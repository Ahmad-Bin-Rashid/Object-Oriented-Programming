using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Player
    {
        public string name;
        public double hp;
        public double maxHp;
        public double energy;
        public double maxEnergy;
        public double armor;
        public Stats SkillStatistics = new Stats();
        public Player(string name, int hp, int energy, int armor)
        {
            this.name = name;
            this.hp = hp;
            this.maxHp = hp;
            this.energy = energy;
            this.maxEnergy = energy;
            this.armor = armor;
        }
        public void LearnSkill(Stats skills)
        {
            this.SkillStatistics.skillname = skills.skillname;
            this.SkillStatistics.description = skills.description;
            this.SkillStatistics.damage = skills.damage;
            this.SkillStatistics.heal = skills.heal;
            this.SkillStatistics.penetration = skills.penetration;
            this.SkillStatistics.cost = skills.cost;
        }
        public void UpdateHealth(double value)
        {
            hp += value;
            if (hp < 0)
            {
                hp = 0;
            }
            else if (hp > maxHp)
            {
                hp = maxHp;
            }
        }
        public void UpdateEnergy(double value)
        {
            energy += value;
            if (energy < 0)
            {
                energy = 0;
            }
            else if (energy > maxEnergy)
            {
                energy = maxEnergy;
            }
        }

        public void UpdateArmor(double value)
        {
            armor += value;
            if (armor < 0)
            {
                armor = 0;
            }
        }
        public string Attack(Player target)
        {
            if (energy < SkillStatistics.cost)
            {
                return $"{name} attempted to use {SkillStatistics.skillname}, but didn't have enough energy!";
            }
            else
            {
                energy -= SkillStatistics.cost;

                double effectiveArmor = target.armor - SkillStatistics.penetration;
                if (effectiveArmor < 0)
                {
                    effectiveArmor = 0;
                }
                double calculatedDamage = SkillStatistics.damage * ((100 - effectiveArmor) / 100);
                target.UpdateHealth(-calculatedDamage);
                string attackResult = $"{name} used {SkillStatistics.skillname}, {SkillStatistics.description}, against {target.name}, doing {calculatedDamage:F2} damage!";
                if (SkillStatistics.heal > 0)
                {
                    UpdateHealth(SkillStatistics.heal);
                    attackResult += $" {name} healed for {SkillStatistics.heal} health!";
                }

                if (target.hp <= 0)
                {
                    attackResult += $" {target.name} died.";
                }
                else
                {
                    attackResult += $" {target.name} is at {((target.hp / target.maxHp) * 100)}% health.";
                }
                return attackResult;
            }
        }
    }
}
