using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    internal class Meat : Food
    {
        public Type MeatType;

        public Meat(int calorie) : base(calorie)
        {
        }

        public Meat(int calorie, Type Meat) : base(calorie)
        {
            MeatType= Meat;
        }
        public enum Type
        {
            Lamb,
            Fish, 
            Beef, 
            Chicken
        }
    }
}
