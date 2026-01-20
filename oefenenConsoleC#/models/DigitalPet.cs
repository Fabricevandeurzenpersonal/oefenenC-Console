//class DigitalPet
//{
//    public string Name { get; set; }
//    public int Energy { get; set; }

//    public
//    DigitalPet(string name)
//    {
//        this.Name = name; // Naam bij aanmaak
//        this.Energy = 50; // Standaard energie bij aanmaak
//    }
//    public void SetEnergy(int amount)
//    {
//        if (amount < 0)
//        {
//            Console.WriteLine("Foutje! Energie mag niet negatief zijn");
//            Console.WriteLine("We zetten de energie op 0.");
//            this.Energy = 0;
//        }
//        else if (amount > 100)
//        {
//            Console.WriteLine("Wow, dat is veel! Maximaal 100.");
//            this.Energy = 100;
//        }
//        else
//        {
//            this.Energy = amount;
//        }
//    }
//    public string EnergyDisplay()
//    {
//        return "🔋 " + this.Name + " - Level: " + this.Energy + "/100";
//    }

//    //public string GetDescription()
//    //{
//    //    return "ik ben " + this.Name + " en ik heb " + this.Energy + " energie";
//    //}
//}
namespace Tamagotchi.models;

class DigitalPet
{
    public string Name { get; set; }
    public int Energy { get; set; }
    public int Hunger { get; set; }
    public bool IsSleeping { get; set; }


    public DigitalPet(string name, int energy = 50, int hunger = 0, bool isSleeping = false)
    {
        this.Name = name;
        this.Energy = energy;
        this.Hunger = hunger;
        this.IsSleeping = isSleeping;
    }  
    public string Sleep()
    {
        this.IsSleeping = true;
        this.Energy += 20;

       
        return "Zzz... Dat deed deugd! (+20 Energie)";
    }
}
