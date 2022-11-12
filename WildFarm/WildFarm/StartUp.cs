using System;
using System.Threading;
using System.Xml.Linq;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] animalData = Console.ReadLine().Split(" ");
            string[] foodData = Console.ReadLine().Split(" ");
            string type = animalData[0];
            string name = animalData[1];
            double weight = double.Parse(animalData[3]);
            Animal animal = null;
            switch (type)
            {
                case "Owl":
                    double wingSize = double.Parse(animalData[2]);
                    int foodEaten = int.Parse(animalData[4]);
                    animal = new Owl(name,weight,foodEaten);
                    break;
                //case "Hen":
                //    hero = new Paladin(name, 0);
                //    break;
                //case "Rogue":
                //    hero = new Rogue(name, 0);
                //    break;
                //case "Warrior":
                //    hero = new Warrior(name, 0);
                //    break;
                //default:
                //    Console.WriteLine("Invalid hero!");
                //    continue;
            }

        }
    }
}
