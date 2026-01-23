using Tamagotchi.Models;

namespace Tamagotchi.models
{
    public class DigitalPet
    {
        public string Name { get; private set; }
        public int Energy { get; private set; }
        public int Hunger { get; private set; }
        public bool IsSleeping { get; private set; }

        public DigitalPet(string name, int energy = 50, int hunger = 0, bool isSleeping = false)
        {
            this.Name = name;
            this.Energy = energy;
            this.Hunger = hunger;
            this.IsSleeping = isSleeping;
        }

        
        public string EnergyDisplay()
        {
            return $"🔋 {this.Name} - Energie: {this.Energy}/100 | Honger: {this.Hunger}/100";
        }

       
        public string Sleep()
        {
            this.IsSleeping = true;
            this.Energy += 20;

            if (this.Energy > 100)
                this.Energy = 100;

            UpdateStatus();
            return "Zzz... Dat deed deugd! (+20 Energie)";
        }

       
        public void UpdateStatus()
        {
            this.Hunger += 5;

            if (this.Hunger > 100)
                this.Hunger = 100;
        }

        
        public void Rename(string newName)
        {
            this.Name = newName;
        }

        
        public string Feed(Food food)
        {
            this.Energy += food.EnergyGain;
            this.Hunger -= 10;

            if (this.Energy > 100)
                this.Energy = 100;

            if (this.Hunger < 0)
                this.Hunger = 0;

            return $"{this.Name} at een {food.Name}. (+{food.EnergyGain} Energie)";
        }
    }
}
