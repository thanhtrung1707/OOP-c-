using System;
namespace Polymorphism
{
    public class Monster
    {
        public string FullName;
        public int AttackPoint;
        public Monster(string fullName)
        {
            FullName = fullName;
        }
        public Monster(string fullName, int attackPoint)
        {
            FullName = fullName;
            AttackPoint = attackPoint;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"Monster {FullName} is attacking");
        }
        public void Attack(string skill)
        {
            Console.WriteLine($"Monster {FullName} is attacking");
            Console.WriteLine($"and using skill {skill}");
        }
        public string Attack(string skill, int repeat)
        {
            var result = $"Monster {FullName} is using skill {skill}" +
                         $" {repeat} times";
            return result;
        }
    }
}