using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    public class Wolf : Animal
    {
        public bool IsPrideLeader;
        public int AttackDamage;



        public Wolf(int avgLifeTime, string bread, int hp, int attackDamage) : base(avgLifeTime, bread, hp)
        {
            AttackDamage = attackDamage;
        }

        public override void Hunt<T>(T animal)
        {
            if(animal is Animal)
            {
                animal.HP -= AttackDamage;
                Console.WriteLine($"The {animal.GetType().Name} was hunted. HP remaining: {animal.HP}");
            }
            else
            {
                Console.WriteLine("Invalid animla type provided for hunting.");
            }
        }
    }
}
