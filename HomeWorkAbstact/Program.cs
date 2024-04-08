using HomeWorkAbstact;

Console.WriteLine("Введите имя собаки: ");
string? name = Console.ReadLine();
Dog dog = new Dog();
dog.SetName(name);
Console.WriteLine($"Имя вашей собаки: {dog.GetName()}");
dog.Eat();