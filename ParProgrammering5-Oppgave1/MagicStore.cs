using System.Text;

namespace ParProgrammering5_Oppgave1;

public class MagicStore
{
    private List<Item> _storeAnimals = [
    new Item("Ugle"),
    new Item("Rotte"),
    new Item("Katt"),
    new Item("Frosk")
    ];
    
    private List<Item> _storeWands =[
    new Item("Føniksstav"),
    new Item("Unikornstav"),
    new Item("Trollstav")];
    
    public StringBuilder PrintInventory(List<Item> _listToPrint)
    {
        StringBuilder sb = new StringBuilder();
        int i = 1;
        foreach (Item item in _listToPrint)
        {
            sb.AppendLine($"{i++}) {item.ToString()}");
        }
        return sb;
    }
    
    public Item BuyAnimal()
    {
        Console.WriteLine(PrintInventory(_storeAnimals));
        Console.WriteLine("Enter the number of the item you want to buy: ");
        int whatItem;
        if (int.TryParse(Console.ReadLine(), out whatItem) && whatItem > 0 && whatItem <= _storeAnimals.Count)
        {
            return _storeAnimals[whatItem - 1];
        }
        return null;
    }

    public Item BuyWand()
    {
        Console.WriteLine(PrintInventory(_storeWands));
        Console.WriteLine("Enter the number of the item you want to buy: ");
        int whatItem;
        if (int.TryParse(Console.ReadLine(), out whatItem) && whatItem > 0 && whatItem <= _storeWands.Count)
        {
            return _storeWands[whatItem - 1];
        }
        return null;
    }
}