namespace Minimalist_Zoo_Animal_Management_System
{
    internal class Program
    {
        class Minimalist_Zoo_Animal_Management_System
        {
            static List<Animal> zooAnimals = new List<Animal>();

            static void Main()
            {
                 List<Animal> zooAnimals = new List<Animal>();

                bool exit = false;

                while (!exit)
                {

                    Console.WriteLine("Welcome to the Minimalist Zoo Animal Management System!");
                    Console.WriteLine("1. Add Animals to the Zoo");
                    Console.WriteLine("2. Display Zoo Animals");
                    Console.WriteLine("3. Add More Animals");
                    Console.WriteLine("4. Display Zoo Animals");
                    Console.WriteLine("5. Observe Animal Actions");
                    Console.WriteLine("6. Exit");

                    int choice = GetChoice();

                    switch (choice)
                    {
                        case 1:
                            AddAnimal();
                            break;
                        case 2:
                            DisplayZooAnimals();
                            break;
                        case 3:
                            AddAnimal();
                            break;
                        case 4:
                            DisplayZooAnimals();
                            break;
                        case 5:
                            ObserveAnimalActions();
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                            break;
                    }
                }

                Console.WriteLine("Thank you for using the Minimalist Zoo Animal Management System!");
            }

            static int GetChoice()
            {
                Console.Write("Enter your choice: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        return choice;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter a number: ");
                    }
                }
            }

            static void AddAnimal()
            {
                Console.Write("Enter Animal Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Animal Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Animal Species: ");
                string species = Console.ReadLine();

                Console.WriteLine("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore): ");
                int dietChoice = GetChoice();
                DietType diet = (DietType)dietChoice;

                Animal newAnimal = new Animal(name, age, species, diet);
                zooAnimals.Add(newAnimal);

                Console.WriteLine("Animal Added Successfully!");
            }

            static void DisplayZooAnimals()
            {
                Console.WriteLine("------------------------");
                foreach (var animal in zooAnimals)
                {
                    Console.WriteLine($"Animal: {animal.Name}, Age: {animal.Age}, Species: {animal.Species}, Diet: {animal.Diet}");
                }
                Console.WriteLine("------------------------");
            }

            static void ObserveAnimalActions()
            {
                foreach (var animal in zooAnimals)
                {
                    switch (animal.Name.ToLower())
                    {
                        case "lion":
                            Console.WriteLine("- Lion makes a roaring sound.");
                            break;
                        case "eagle":
                            Console.WriteLine("- Eagle soars through the sky.");
                            break;
                        default:
                            Console.WriteLine($"Observing {animal.Name} actions...");
                            break;
                    }
                }
            }
        }

        enum DietType
        {
            Carnivore = 1,
            Herbivore,
            Omnivore
        }

        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Species { get; set; }
            public DietType Diet { get; set; }

            public Animal(string name, int age, string species, DietType diet)
            {
                Name = name;
                Age = age;
                Species = species;
                Diet = diet;
            }
        }

    }
}

