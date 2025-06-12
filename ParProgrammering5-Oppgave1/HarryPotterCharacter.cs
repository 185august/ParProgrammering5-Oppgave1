using System.Text;

namespace ParProgrammering5_Oppgave1;

public class HarryPotterCharacter
{
    private string _name;
    private string _house;
    List <Item>_inventory;

    public HarryPotterCharacter(string name, string house)
    {
        _name = name;
        _house = house;
        _inventory = new List<Item>();
    }

    public override string ToString()
    {
        return $"{_name} lives in {_house} and has the following items: \n{PrintInventory()}";
    }

    public StringBuilder PrintInventory()
    {
        
        StringBuilder sb = new StringBuilder();
        if (_inventory.Count == 0)
        {
            return sb.AppendLine("You have no items");
        }
        foreach (Item item in _inventory)
        {
            sb.AppendLine(item.ToString());
        }
        return sb;
    }
    
    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }

    public string UseMagic()
    {
        Console.WriteLine("Write the name of the spell you want to use:");
        var spell = Console.ReadLine();
        if (spell.ToLower() == "vingardium leviosa")
        {
            return "The feather is flying";
        }
        if (spell.ToLower() == "hokus pokus")
        {
            return "fireworks is going off";
        }
        return "This spell does not exist";
    }
}