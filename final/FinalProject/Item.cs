class Item
{
    private string _name;
    private int _stat;
    private string _statType;
    private int _cost;
    public Item()
    {
    }
    public Item(string name, int stat, string statType)
    {
        _name = name;
        _stat = stat;
        _statType = statType;
        _cost = 0;
    }
    public Item(string name, int stat, string statType, int cost)
    {
        _name = name;
        _stat = stat;
        _statType = statType;
        _cost = cost;
    }
    public  string GetName()
    {
        return _name;
    }
    public void Display()
    {
        Console.Write($"{_name}|{_statType.PadLeft(40-_name.Length)}: {_stat.ToString().PadRight(15)} cost: {_cost} ");
    }
    public int GetCost()
    {
        return _cost;
    }
public string GetStringRepresentation()
    {
        return $"{_name} ~{_stat} ~{_cost} ~{_statType}";
    }
}