namespace ParProgrammering5_Oppgave1;

public class MagicStoreMenu
{
    private readonly MagicStore MagicStore = new MagicStore();
    public void Run(HarryPotterCharacter character1)
    {
        Console.WriteLine("""
                          Welcome to the Magic Store!
                          1) Buy an Animal 
                          2) Buy a wand 
                          """);
        var valg = Console.ReadLine();
        switch (valg)
        {
            case "1":
                character1.AddItem(MagicStore.BuyAnimal());
                break;
            case "2":
                character1.AddItem(MagicStore.BuyWand());
                break;
            default:
                Console.WriteLine("Ikke gyldig valg");
                break;
        }
    }
}