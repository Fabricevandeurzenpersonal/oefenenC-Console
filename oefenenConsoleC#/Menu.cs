using Figgle.Fonts;
namespace Tamagotchi;

public class Menu
{
    public void ShowTitle()
    {
        Console.Clear();
        try { Console.WriteLine(FiggleFonts.Standard.Render("Tamagotchi")); }
        catch { Console.WriteLine("===Tamagotchi==="); }
    }

    public string AskString(string question)
    {
        Console.Write(question + " ");
        return Console.ReadLine() ?? " ";
    }
    
    public void WaitForEnter()
    {
        Console.WriteLine("\nDruk op Enter om verder te gaan...");
        Console.ReadLine();
    }
    public void ShowMainMenu(int petCount)
    {
        Console.WriteLine($"\n--- HOOFDMENU ({petCount} dieren) ---");
        Console.WriteLine("1. Voeg een nieuw huisdier toe");
        Console.WriteLine("2. Bekijk je huisdieren");
        Console.WriteLine("3. Dier zoeken & Selecteren");
        Console.WriteLine("Q. Stoppen");
        Console.Write("Maak een keuze:");
    }
}