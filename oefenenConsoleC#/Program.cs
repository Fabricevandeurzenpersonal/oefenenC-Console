DigitalPet dino = new DigitalPet();
dino.Name = "Rex";
dino.Energy = 100;

DigitalPet fluffy  = new DigitalPet();
fluffy.Name = "Fluffy";
fluffy.Energy = 80;

Console.WriteLine(dino.GetDescription());
Console.WriteLine(fluffy.GetDescription());

Console.ReadLine();