
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

DigitalPet dino = new DigitalPet("Rex");
Console.WriteLine("Welkom bij " + dino.Name);


DigitalPet fluffy = new DigitalPet("Fluffy");
Console.WriteLine("welkom bij " + fluffy.Name);


Food apple = new Food("Appel", 10);

Console.WriteLine("We hebben een dier: " + dino.Name);
Console.WriteLine("En we hebben eten: " + apple.Name);

Console.WriteLine("Het wordt laat...");


Console.WriteLine(dino.Sleep());
Console.ReadLine();
