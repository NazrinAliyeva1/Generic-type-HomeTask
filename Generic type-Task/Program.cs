using Generic_type_Task.Models;
using System.Threading;

namespace Generic_type_Task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ////First section
            //Wolf wolf = new Wolf(avgLifeTime: 12, bread: "Gray Wolf", hp: 120, attackDamage: 50)
            //{
            //    AnimalGender = Animal.Gender.Male,
            //    IsPrideLeader = true
            //};

            //Elephant elephant = new Elephant(avgLifeTime: 50, bread: "African Elephant", hp: 800, weight: 6000);

            //Console.WriteLine($"Before hunting, Wolf's HP: {wolf.HP}");
            //wolf.Hunt(elephant);
            //Console.WriteLine($"After hunting, Wolf's HP: {wolf.HP}");

            //Console.WriteLine("\n");
            //Meat steak = new Meat(calorie: 400, Meat: Meat.Type.Beef);

            //Grass hay = new Grass(calorie: 250, "Orchard Grass");

            //Console.WriteLine($"Steak calory: {steak.Calorie}, Type: {steak.MeatType}");
            //Console.WriteLine($"Hay calory: {hay.Calorie}, Type: {hay.Name}");

            //Console.WriteLine("\n \n");

            // Second section
            //Wolf wolf = new Wolf(avgLifeTime: 21, bread: "inare", hp: 70, 20)
            //{
            //    IsPrideLeader = true,
            //    AnimalGender=Animal.Gender.Female
            //};
            //Elephant elephant = new Elephant(avgLifeTime: 78, bread: "Aynur", hp: 700,  weight : 90)
            //{
            //    IsTrained=true
            //};

            //Console.WriteLine("Wolf is hunting the elephant...");
            //wolf.Hunt(elephant);

            //Console.WriteLine($"After hunting, Wolf's HP: {wolf.HP}");

            //Console.WriteLine("\n");
            //ZooCage<Wolf, Meat> wolfCage = new ZooCage<Wolf, Meat>(wolf, new Meat(calorie: 500) { MeatType = Meat.Type.Chicken });

            //ZooCage<Elephant, Grass> elephantCage = new ZooCage<Elephant, Grass>(elephant, new Grass(calorie: 700, name: "Rye Grass"));

            //Console.WriteLine($"Wolf's cage: {wolfCage.Food.MeatType}");
            //Console.WriteLine($"Elephant's cage: {elephantCage.Food.Name}");

            //Console.ReadLine();


            ///Task 3 
            Student student = new Student("Aytac Verdiyeva");
            student.IsPlagiated = false;
            student.IsHelpedToPlagiate = false;

            Lion lion  = new Lion();

            if(student.IsPlagiated ||student.IsHelpedToPlagiate)
            {
                lion.Parcalamaq(student);
            }
            else
            {
                Console.WriteLine("Bir dahaki sefere (not Amin)");
            }


        }
    }
}
