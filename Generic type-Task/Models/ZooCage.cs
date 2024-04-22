using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type_Task.Models
{
    public class ZooCage<T, U>
    
        where T: Animal
        where U: Food
    {
        public T Animal;
        public U Food;
        public ZooCage(T animal, U food)
        {
            Animal = animal;
            Food = food;
        }
    }

}
