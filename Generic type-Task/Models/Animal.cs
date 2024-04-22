using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    public abstract class Animal
    {
        public int AvgLifeTime;
        public Gender AnimalGender; // Use AnimalGender enum here
        public string Breed;
        public int HP;

        public enum Gender
        { 
            Male,
            Female
        }
        protected Animal(int avgLifeTime, string bread, int hp)
        {
            AvgLifeTime = avgLifeTime;
            AnimalGender = Gender.Male; // Default to Male
            Breed = bread;
            HP = hp;

        }
        public abstract void Hunt<T>(T animal) where T : Animal;


    }
}
