using System;

class Animal<T>
{
    private T data;

    // Constructor
    public Animal(T value)
    {
        data = value;
    }

    // Method to retrieve the animal data
    public T GetAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to input animal information
        Console.WriteLine("Enter animal information:");

        Console.Write("Animal Name: ");
        string animalName = Console.ReadLine();
        Animal<string> animal = new Animal<string>(animalName);

        Console.Write("Animal Habitat: ");
        string animalHabitat = Console.ReadLine();
        Animal<string> habitat = new Animal<string>(animalHabitat);

        Console.Write("Endangered (true/false): ");
        bool endangered = bool.Parse(Console.ReadLine());
        Animal<bool> isEndangered = new Animal<bool>(endangered);

        Console.Write("Extinct (true/false): ");
        bool extinct = bool.Parse(Console.ReadLine());
        Animal<bool> isExtinct = new Animal<bool>(extinct);

        Console.Write("Average Lifespan (years): ");
        int averageLifespan = int.Parse(Console.ReadLine());
        Animal<int> lifespan = new Animal<int>(averageLifespan);

        // Print out the values using the GetAnimal method
        Console.WriteLine("\nAnimal Information:");
        Console.WriteLine("Animal Name: " + animal.GetAnimal());
        Console.WriteLine("Animal Habitat: " + habitat.GetAnimal());
        Console.WriteLine("Endangered: " + isEndangered.GetAnimal());
        Console.WriteLine("Extinct: " + isExtinct.GetAnimal());
        Console.WriteLine("Average Lifespan: " + lifespan.GetAnimal() + " years");
    }
}
