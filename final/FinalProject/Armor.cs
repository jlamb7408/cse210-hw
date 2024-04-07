class Armor : Item
{
    public Armor(string name, int stat) : base(name, stat, "protection"){}
    public Armor(string name, int stat, int cost) : base(name, stat, "protection", cost){}
}