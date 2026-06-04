using System;

enum Habitat
{
        Wild,
        Sanctuary,
        Zoo
}

class Panda
{
        public string Name;
        public int Age;
        public readonly int Legs = 4;
        public Habitat Location;
        
        public Panda(string name, int age, Habitat location)
    {
        Name = name;
        Age = age;
        Location = location;
    }
}

class Program
{
    static void Main()
    {
        Panda myPanda = new Panda("Mei", 5, Habitat.Sanctuary);

        Console.WriteLine("Panada Name: " + myPanda.Name);
        Console.WriteLine("Age: " + myPanda.Age);
        Console.WriteLine("Legs: " + myPanda.Legs);
        Console.WriteLine("Habitat: " + myPanda.Location);
    }
}