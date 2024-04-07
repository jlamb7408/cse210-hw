class Weapon : Item
{
    public Weapon(string name, int stat) : base(name, stat, "attack"){}
    public Weapon(string name, int stat, int cost) : base(name, stat, "attack", cost){}
    
}