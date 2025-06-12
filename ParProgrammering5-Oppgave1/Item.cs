namespace ParProgrammering5_Oppgave1;

public class Item
{
    private string _name;

    public Item(string name)
    {
        _name = name;
    }
    
    public override string ToString()
    {
        return $"{_name}";
    }
}