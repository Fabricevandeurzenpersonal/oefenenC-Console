using System.IO;
using System.Text.Json;

using Tamagotchi.models;
using Tamagotchi.Models;

namespace Tamagotchi;

public class Game
{
    private Menu _menu = new Menu();
    private DigitalPet _currentPet = null;
    private List<DigitalPet> _pets = new List<DigitalPet>();
    private Dictionary<string, Food> _pantry = new Dictionary<string, Food>();

    public Game()
    {
        _pantry.Add("Appel", new Food("Appel", 10));
        _pantry.Add("Brood", new Food("Brood", 20));
        _pantry.Add("Biefstuk", new Food("Biefstuk", 50));
    }

    public void Start()
    {
        LoadGame();

        _menu.WaitForEnter();
        _menu.ShowTitle();

        bool appRunning = true;

        while (appRunning)
        {
            // --- MAIN MENU ---
            if (_currentPet == null)
            {
                _menu.ShowMainMenu(_pets.Count);
                string choice = _menu.AskString("");

                switch (choice.ToUpper())
                {
                    case "1":
                        string name = _menu.AskString("Naam:");
                        int energy = _menu.AskInt("Energie (0-100):");
                        int hunger = _menu.AskInt("Honger (0-100):");

                        _pets.Add(new DigitalPet(name, energy, hunger));
                        Console.WriteLine("Toegevoegd!");
                        _menu.WaitForEnter();
                        break;

                    case "2":
                        Console.WriteLine("\n--- ALLE DIEREN ---");
                        foreach (var pet in _pets)
                        {
                            Console.WriteLine(pet.EnergyDisplay());
                        }
                        _menu.WaitForEnter();
                        break;

                    case "3":
                        string search = _menu.AskString("Wie zoek je?");
                        _currentPet = _pets.FirstOrDefault(p => p.Name.ToLower() == search.ToLower());

                        if (_currentPet == null)
                        {
                            Console.WriteLine("Niet gevonden.");
                            _menu.WaitForEnter();
                        }
                        break;

                    case "Q":
                        SaveGame();
                        appRunning = false;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        _menu.WaitForEnter();
                        break;
                }
            }

            // --- PET MENU ---
            else
            {
                _menu.ShowPetMenu(_currentPet.Name, _currentPet.Energy, _currentPet.Hunger);
                string action = _menu.AskString("Actie:");

                switch (action)
                {
                    case "1": // eten geven
                        Console.WriteLine("\n--- VOORRAADKAST ---");
                        Console.WriteLine(string.Join(", ", _pantry.Keys));

                        string foodChoice = _menu.AskString("Wat wil je geven?");

                        if (_pantry.ContainsKey(foodChoice))
                        {
                            Food item = _pantry[foodChoice];
                            string result = _currentPet.Feed(item);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("Dat hebben we helaas niet in huis.");
                        }

                        _menu.WaitForEnter();
                        break;

                    case "0": // terug
                        _currentPet = null;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        _menu.WaitForEnter();
                        break;
                }
            }
        }
    }

    private void SaveGame()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        string json = JsonSerializer.Serialize(_pets, options);

        File.WriteAllText("dieren.json", json);

        Console.WriteLine("Spel succesvol opgeslagen!");
    }

    private void LoadGame()
    {
        if (File.Exists("dieren.json"))
        {
            string json = File.ReadAllText("dieren.json");

            _pets = JsonSerializer.Deserialize<List<DigitalPet>>(json) ?? new List<DigitalPet>();

            Console.WriteLine($"Savegame geladen: {_pets.Count} dieren gevonden.");
        }
        else
        {
            Console.WriteLine("Geen opgeslagen spel gevonden. We beginnen opnieuw.");
        }
    }
}
