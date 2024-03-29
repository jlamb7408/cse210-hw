class Item
{
    private string _name;
    private int _stat;
    private string _statType;
    public Item(string name, int stat, string statType)
    {
        _name = name;
        _stat = stat;
        _statType = statType;
    }
    public void Display()
    {
        Console.Write($"{_name}|    {_statType}: {_stat}");
    }

}