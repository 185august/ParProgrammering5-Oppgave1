namespace ParProgrammering5_Oppgave1;

public class GameMenu
{
    private readonly MagicStore MagicStore = new MagicStore();
    

    public void Run(HarryPotterCharacter character1)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("""
                              Valg '1' bruk magi
                              Valg '2' gå til buttikken
                              Valg '3' Vis inventory  
                              Valg '4' avslutt
                              """);
            var valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    Console.WriteLine(character1.UseMagic());
                    break;
                case "2":
                    StoreMenu(character1);
                    break;
                case "3":
                    Console.WriteLine(character1.PrintInventory());
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ikke gyldig valg");
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        } while (true);
    }

    public void StoreMenu(HarryPotterCharacter character1)
    {
        Console.Clear();
        Console.WriteLine("""
                          Welcome to the Magic Store!
                          1) Buy an Animal 
                          2) Buy a wand 
                          """);
        var valg = Console.ReadLine();
        switch (valg)
        {
            case "1":
                var itemAnimal = MagicStore.BuyAnimal();
                character1.AddItem(itemAnimal);
                Console.WriteLine($"You have bought {itemAnimal.ToString()}");
                break;
            case "2":
                var itemWand = MagicStore.BuyWand();
                character1.AddItem(itemWand);
                Console.WriteLine($"You have bought {itemWand.ToString()}");
                break;
            default:
                Console.WriteLine("Ikke gyldig valg");
                break;
        }
        
    }
}