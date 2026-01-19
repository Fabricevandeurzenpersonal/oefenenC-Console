class DigitalPet
{
    public string Name { get; set; }
    public int Energy { get; set; }


    public string GetDescription()
    {
        return "ik ben " + this.Name + " en ik heb " + this.Energy + " energie";
    }
}
