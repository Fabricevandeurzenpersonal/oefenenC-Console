namespace Tamagotchi.Models;

public class DigitalPet
{
    public string Name { get; set; }

    public DigitalPet(string name)
    {
        this.Name = name;
    }
}