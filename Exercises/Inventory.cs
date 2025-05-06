using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    // INVENTORY
    internal class Inventory
    {
        public static void Run()
        {
            Console.WriteLine("Inventory");

            // define class instances
            Pack pack1 = new Pack(10, 30, 30);
            Food bread = new Food("bread", 3, 3, 200);
            Food water = new Food("water", 3, 3, 100);
            Tool axe = new Tool("axe", 3, 3, 1000);

            bread.GetItemDetails();
            water.GetItemDetails();
            axe.GetItemDetails();

            pack1.AddItem(bread, 0);
            pack1.AddItem(water, 1);
            pack1.AddItem(axe, 2);
            pack1.AddItem(new Tool("saw", 4, 1, 1500), 4);

            pack1.getAllItems();
        }
    }

    // Classes
    // Abstract Class - cant be used directly
    abstract class InventoryItem
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }

        public InventoryItem(string name, int weight, int volume)
        {
            Name = name;
            Weight = weight;
            Volume = volume;
            Console.WriteLine($"{name} {Weight} {Volume}");
        }

        public virtual void GetItemDetails()
        {
            Console.WriteLine($"ITEM : {Name} {Weight} {Volume}");
        }
    }

    class Food : InventoryItem
    {
        public int Calories { get; set; }
        public Food(string name, int weight, int volume, int calories) : base(name, weight, volume)
        {
            Calories = calories;
        }

        public void eat()
        {
            Console.WriteLine($"Eating {Name}");
        }

        public override void GetItemDetails()
        {
            Console.WriteLine($"FOOD : {Name} {Weight} {Volume} calories : {Calories}");
        }
    }

    class Tool : InventoryItem
    {
        public int Durability { get; set; }

        public Tool(string name, int weight, int volume, int durability) : base(name, weight, volume)
        {
            Durability = durability;
        }

        public void use()
        {
            Console.WriteLine($"Using {Name}");
        }

        public void GetItemDetails()
        {
            Console.WriteLine($"TOOL : {Name} {Weight} {Volume} durability : {Durability}");
        }
    }

    class Pack
    {
        public InventoryItem[] InventoryItemList { get; set; }
        public int MaxWeight { get; set; }
        public int MaxVolume { get; set; }

        public Pack(int size, int maxWeight, int maxVolume)
        {
            InventoryItemList = new InventoryItem[size];
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }

        public bool AddItem(InventoryItem item, int index)
        {
            if (index >= 0 && index < InventoryItemList.Length)
            {
                InventoryItemList[index] = item;
                return true;
            }
            else
            {
                Console.WriteLine("Out of bounds!");
                return false;
            }
        }

        public void getAllItems()
        {
            Console.WriteLine("All Items in Pack: ");
            foreach (InventoryItem x in InventoryItemList)
            {
                if (x is Food)
                {
                    // overrides Item.getItemDetails()
                    x.GetItemDetails();
                }
                if (x is Tool)
                {
                    x.GetItemDetails();
                }

            }
        }
    }


}


