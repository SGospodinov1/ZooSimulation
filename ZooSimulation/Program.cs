using ZooSimulation.Models;



List<Animal> animals = new List<Animal>()
            {
                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Lion(),
                new Lion(),
                new Lion(),
                new Lion(),
                new Lion(),
                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Monkey()
            };

Console.WriteLine("Welcome to Zoo Simulation, please enter a command:");

string command = Console.ReadLine();

while (animals.Count != 0)
{
    if (command == "Starvation")
    {
        foreach (var animal in animals)
        {
            animal.Starvation();

            Console.WriteLine($"{animal.GetType().Name} health is {animal.Health}");

            if (animal.IsAlive == false)
            {
                Console.WriteLine($"{animal.GetType().Name} is dead.");
            }
        }

        Console.WriteLine("");

        LiveAnimals(animals);

        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine("");

    }
    else if (command == "Feeding")
    {
        foreach (var animal in animals)
        {
            animal.Feeding();


            Console.WriteLine($"{animal.GetType().Name} health is {animal.Health}");
        }

        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine("");

    }
    else
    {
        Console.WriteLine("Please enter a valid command");
    }

    command = Console.ReadLine();
}




void LiveAnimals(List<Animal> animals)
{
    int count = animals.Count;

    foreach (var animal in animals)
    {
        if (animal.IsAlive == false)
        {
            count--;

        }
    }

    animals.RemoveAll(x => x.IsAlive == false);

    Console.WriteLine($"Live animals: {count}");

}
