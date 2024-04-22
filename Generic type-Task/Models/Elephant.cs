using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    public class Elephant : Animal
    {
        public double Weight;
        public bool IsTrained;
        public Elephant(int avgLifeTime, string bread, int hp, double weight) : base(avgLifeTime, bread, hp)
        {
            Weight= weight;
            IsTrained= false;
        }


        public override void Hunt<T> (T animal)
        {
            if (animal is Animal)
            {
                animal.HP -= 150;
                Console.WriteLine($"The {animal.GetType().Name} was hunted! HP remaining: {animal.HP}");
            }
        }
    }
}
