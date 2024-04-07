using System.Runtime.CompilerServices;

class PointTracker
{
        private string _characterName = "New Comer";

        private int _points = 0;
        private Weapon _equipedWeapon = new Weapon("Fists", 1);
        private Armor _equipedArmor = new Armor("Old Shirt", 1);
        private List<Item> _store;
        private List<Item> _invenntory = new List<Item>{new Weapon("Fists", 1), new Armor("Old Shirt", 1)};
        private string _fileName = "";
        public PointTracker()

        {
                //all of these items create the store where the user can buy items
                Weapon Gauntlet = new Weapon("Thanos's Gauntlet", 100, 500);
                Weapon LightSaber = new Weapon("Obiwan's Lightsaber", 50, 250);
                Weapon LinkSword = new Weapon("The Master Sword", 25, 100);
                Weapon Crossbow = new Weapon("Chewie's Crossbow", 20, 50);
                Weapon AragornSword = new Weapon("Aragorn's Sword", 25, 100);
                Armor Clone = new Armor("Clone Armor", 25, 50);
                Armor Mithril = new Armor("Mithril coat", 75, 150);
                Armor IronMan = new Armor("IronMan Suit", 50, 125);
                Armor Halo = new Armor("Maser Cheif's Armor", 35, 75);
                List<Item> Store = new List<Item>{Gauntlet, LightSaber, LinkSword, Crossbow, AragornSword, Clone, Mithril, IronMan, Halo};
                _store = Store;
        }
        private void StoreReset()
        //The store items are reset to all being in stock
        {
                //There is a point where the store might need to be reset if a user loads a save file with less progress than the current open file
                Weapon Gauntlet = new Weapon("Thanos's Gauntlet", 100, 500);
                Weapon LightSaber = new Weapon("Obiwan's Lightsaber", 50, 250);
                Weapon LinkSword = new Weapon("The Master Sword", 25, 100);
                Weapon Crossbow = new Weapon("Chewie's Crossbow", 20, 50);
                Weapon AragornSword = new Weapon("Aragorn's Sword", 25, 100);
                Armor Clone = new Armor("Clone Armor", 25, 50);
                Armor Mithril = new Armor("Mithril coat", 75, 150);
                Armor IronMan = new Armor("IronMan Suit", 50, 125);
                Armor Halo = new Armor("Maser Cheif's Armor", 35, 75);
                List<Item> Store = new List<Item>{Gauntlet, LightSaber, LinkSword, Crossbow, AragornSword, Clone, Mithril, IronMan, Halo};
                _store = Store;
        }
        public void DisplayCharacter()
        //The equiped items of the character are displayed
        {
                Console.WriteLine($"Equpied weapon: {_equipedWeapon.GetName()}");
                Console.WriteLine($"Equpied armor: {_equipedArmor.GetName()}");
        }
        public void BuyItems()
        //The store is displayed and the suer can choose an item to buy if they have enough points
        {
                Console.Clear();
                Console.WriteLine("Welcome to the item shop! Our Items for sale:");
                if (_store.Count > 0)
                {
                        int i = 1;
                        foreach (Item item in _store)
                        {
                                Console.WriteLine();
                                Console.Write(i + ". " );
                                item.Display();
                                i++;
                        }
                        Console.WriteLine();
                        Console.WriteLine($"\nYou currently have {_points} points");
                        Console.WriteLine("If you would like to buy an item, enter the number of the item, or press enter to return to the menu");
                        string str_UserChoice = Console.ReadLine();
                        int userChoice; 
                        Console.Clear();

                        if (int.TryParse(str_UserChoice, out userChoice))
                        {
                                int itemSelection = userChoice - 1;
                                Item itemBought = _store[itemSelection];
                                int itemCost = itemBought.GetCost();
                                if(_points < itemCost)
                                {
                                        Console.WriteLine($"You cannot afford that item\n");
                                }
                                else
                                {
                                        _points = _points - itemCost;
                                        _store.RemoveAt(itemSelection);
                                        _invenntory.Add(itemBought);
                                        Console.WriteLine("You have purchased the item, would you like to equip it now? (yes or no)");
                                        if (Console.ReadLine() == "yes")
                                        {
                                                if (itemBought is Weapon)
                                                {
                                                        _equipedWeapon = itemBought as Weapon;
                                                }
                                                else if (itemBought is Armor)
                                                {
                                                        _equipedArmor = itemBought as Armor;
                                                }
                                        }
                                }
                        
                        }
                        else
                        {
                        Console.WriteLine("Farwell Traveller\n");
                        }
                }
                else
                {
                        Console.WriteLine($"Welcome to the item shop. We are sold out at the moment\n");
                }
                
        }
        public void VeiwInentory()
        //A user is taken to a menus where hthey can change their name, veiw their items, and equip items
        {
                Console.Clear();
                Console.WriteLine($"Welcome {_characterName}");
                DisplayCharacter();
                Console.WriteLine($"Points {_points}");
                Console.WriteLine("Inventory Options: ");
                Console.WriteLine(" 1. Change Character Name");
                Console.WriteLine(" 2. View Items");
                Console.WriteLine(" 3. Equip a Weapon");
                Console.WriteLine(" 4. Equip Armor");
                Console.WriteLine("Choose between 1-4 or hit enter to return to the main menu");
                string str_UserChoice = Console.ReadLine();
                int userChoice; 
                Console.Clear();

                if (int.TryParse(str_UserChoice, out userChoice))
                {
                        if(userChoice == 1)     //Change name selected
                        {
                                Console.WriteLine("What would you like youre name to be? ");
                                _characterName = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"You will now be known as {_characterName}");
                                Console.WriteLine();
                        }
                        else if(userChoice == 2)        //Show inventory selected
                        {
                                Console.WriteLine("Your Inventory:");
                                int i = 1;
                                foreach(Item item in _invenntory)
                                {
                                        Console.WriteLine();
                                        Console.Write(i + ". " );
                                        item.Display();
                                        i++;
                                }
                                Console.WriteLine();
                                DisplayCharacter();
                                Console.WriteLine("Press enter to continue to main menu:");
                                Console.ReadLine();
                        }   
                        else if(userChoice == 3)        //Equip a weapon selected
                        {
                                List<Weapon> weapons = new List<Weapon>();
                                foreach(Item item in _invenntory)
                                {
                                        if(item is Weapon)
                                        {
                                                weapons.Add(item as Weapon);
                                        }
                                } 
                                int j = 1;
                                foreach(Weapon weapon in weapons)
                                {
                                        Console.Write($"\n{j}. ");
                                        weapon.Display();
                                        j++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Which number would you like to equip?");
                                string str_weaponChoice = Console.ReadLine();
                                int weaponChoice; 
                        
                                if (int.TryParse(str_weaponChoice, out weaponChoice))
                                {
                                        Weapon weaponSelected = weapons[weaponChoice-1];
                                        _equipedWeapon = weaponSelected;
                                        Console.Clear();
                                        Console.WriteLine("Your weapon has been equiped\n");
                                }
                                else
                                {
                                        Console.WriteLine("Action Cancled\n");
                                }
                                
                        }
                        else if (userChoice == 4)       //Equip armor selected
                        {
                                List<Armor> armor = new List<Armor>();
                                foreach(Item item in _invenntory)
                                {
                                        if(item is Armor)
                                        {
                                                armor.Add(item as Armor);
                                        }
                                } 
                                int j = 1;
                                foreach(Armor arm in armor)
                                {
                                        Console.Write($"\n{j}. ");
                                        arm.Display();
                                        j++;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Which number would you like to equip?");
                                string str_armorChoice = Console.ReadLine();
                                int armorChoice; 
                        
                                if (int.TryParse(str_armorChoice, out armorChoice))
                                {
                                        Armor armorSelected = armor[armorChoice-1];
                                        _equipedArmor = armorSelected;
                                        Console.Clear();
                                        Console.WriteLine("Your armor has been equiped\n");
                                }
                                else
                                {
                                        Console.WriteLine("Action Cancled\n");
                                }
                        }
                        else
                        {
                              Console.WriteLine("Action Cancled\n");  
                        }
                }


        } 
        public void AddPoints(int points)
        //points are added to their total poitns every time they complete an activity
        {
                _points = _points + points;
        }
        public void Save()
        //the user cna save their progress to a tect file
        {
                Console.Clear();
                bool ChangeFileName = true;
                if(_fileName != "")
                {
                Console.WriteLine("If you would like to save to the same file as before, enter 1");
                Console.WriteLine("If you would like to save to a new file, press enter: ");
                string str_fileChoice = Console.ReadLine();
                int fileChoice;
                
                //This if statement checks to see if an int was entered, if no int is entered the user will be asked for a file name
                if(int.TryParse(str_fileChoice, out fileChoice))
                {
                        if (fileChoice == 1)
                        {
                        ChangeFileName = false;
                        }
                }
                }
                if(ChangeFileName)
                {
                Console.WriteLine("What would you like the title of this save file to be? ");
                _fileName = Console.ReadLine();
                }
                using (StreamWriter outputfile = new StreamWriter(_fileName))
                {
                        outputfile.WriteLine($"{_characterName} ~{_points}");
                        outputfile.WriteLine($"WepEQ ~{_equipedWeapon.GetStringRepresentation()}");
                        outputfile.WriteLine($"ArmEQ ~{_equipedArmor.GetStringRepresentation()}");
                        foreach(Item item in _invenntory)
                        {
                                outputfile.WriteLine(item.GetStringRepresentation());
                        }
                }
                        Console.Clear();
                        Console.WriteLine("Your progross has been saved!\n");
        }
        public void Load()
        //The user can load their progress from a text file
        {
                Console.Clear();
                List<Item> loadedItems = new List<Item>();

                Console.WriteLine("What is the name of the save file to be loaded? ");
                _fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(_fileName);

                foreach (string line in lines)
                {   
                        string[] parts = line.Split(" ~");

                        if (parts.Count() == 2) //The first line has the points and level of the user, this if statment saves them to the apropiate variables
                        {
                                _characterName = parts[0];
                                _points = int.Parse(parts[1]);
                        }
                        else if (parts.Count() == 5)
                        {
                                if (parts[0] == "WepEQ")
                                {
                                        _equipedWeapon = new Weapon(parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                                }
                                else if (parts[0] == "ArmEQ")
                                {
                                        _equipedArmor = new Armor(parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                                }
                        }
                        else
                        {
                                Item loadedItem = new Item();
                                //The first part of each line will be the type of goal, these if staments will take the type of goal and save them to the proper class
                                if(parts[3] == "attack")
                                {
                                        loadedItem = new Weapon(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                                }
                                else if(parts[3] == "protection")
                                {
                                        loadedItem = new Armor(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                                }

                                loadedItems.Add(loadedItem);
                        }
                }
                _invenntory = loadedItems;

                //Here I make sure that all the items in the users inventory do not also show up in the store so that items can only be bought once
                // I also make sure that if the user loads a file where they havent bought the item yet, it will restock
                StoreReset();
                List<string> inventoryNames = new List<string>();
                foreach(Item item in _invenntory)
                {
                        string name = item.GetName();
                        inventoryNames.Add(name);
                }
                for (int i = 0; i < _store.Count; i++)
                {
                        string storeItem = _store[i].GetName();
                        if (inventoryNames.Contains(storeItem))
                        {
                                _store.RemoveAt(i);
                        }
                        
                }
                Console.Clear();
                Console.WriteLine("Your progress has been loaded.\n");
        }


}