
////oude manier
//DigitalPet dino = new DigitalPet();
////dino.Name = "Rex";
//////dino.Energy = 100;
////Console.WriteLine("Poging 1: -50 energie");
////dino.SetEnergy(-50);
////Console.WriteLine(dino.EnergyDisplay());

////Console.WriteLine("Poging 2: 150 energie");
////dino.SetEnergy(150);

////DigitalPet fluffy  = new DigitalPet();
////fluffy.Name = "Fluffy";
//////fluffy.Energy = 80;
////Console.WriteLine("Poging 3: 80 energie");
////fluffy.SetEnergy(80);

////nieuwe manier met constructor
//DigitalPet dino = new DigitalPet("Rex");
//DigitalPet fluffy = new DigitalPet("Fluffy");
//Console.WriteLine(dino.Name);
//Console.WriteLine(dino.Energy);
//Console.WriteLine(fluffy.Name);
//Console.WriteLine(fluffy.Energy);

//Console.ReadLine();
using Figgle.Fonts;
using Tamagotchi.models;
using Tamagotchi.Models;


string banner = FiggleFonts.Standard.Render("Tamagotchi");

Console.WriteLine(banner);

List<DigitalPet> pets = new List<DigitalPet>();

Console.Write("Voer de naam van je huisdier in (of druk op ENTER om te stoppen): ");

while (true)
{
    Console.Write("\nNaam huisdier: ");
    string? input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Geen naam ingevoerd, stoppen met toevoegen van huisdieren.");
        break;
    }
    pets.Add(new DigitalPet(input));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"\n--- Huidige dieren in opvang({pets.Count})---");

    foreach (DigitalPet pet in pets)
    {
        Console.Write($"-\nNaam: {pet.Name} Energie: {pet.Energy}");

    }
    Console.ResetColor();
    Console.WriteLine("\n--------------------------------");
}
Console.WriteLine("\nBedankt voor het gebruik!");
Console.ReadLine();
