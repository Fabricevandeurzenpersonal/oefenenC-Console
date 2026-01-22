using System.Reflection.Metadata;
using Tamagotchi.models;

namespace Tamagotchi;

public class Game
{
    private Menu _menu = new Menu();
    private List<DigitalPet> _pets = new List<DigitalPet>();

    public void Start()
    {
        _menu.ShowTitle();

        bool appRunning = true;

        while (appRunning)
        {
            _menu.ShowMainMenu(_pets.Count);

            string choice = _menu.AskString("Keuze:");
            if (choice.ToUpper() == "Q")
            {
                appRunning = false;
            }
        }
    }
}