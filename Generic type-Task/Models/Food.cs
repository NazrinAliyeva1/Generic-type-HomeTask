using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    public abstract class Food
    {
        public int Calorie;
        public Food(int calorie)
        {
            Calorie=calorie;
        }

    }

}
