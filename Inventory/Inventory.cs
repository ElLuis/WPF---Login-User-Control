using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Inventory
    {
            private int item;
    private string description;
            private int quantity;
            private double price;
            private static List<Inventory> inventory;

            public int Item {

    get {
    return item;
    }
        set { item = value; }
    }

    public string Description
    {
        get
        {
            return description;
        }
        set { description = value; }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
                    quantity = value;
        }
    }

    public double Price
    {

        get { return price; }
        set { price = value; }

    }

    static Inventory()
    {
        inventory = new List<Inventory>();

        inventory.Add(new Inventory
    {
    Item = 83,
    Description = "Electric sander",
    Quantity = 7,
    Price = 59.98,
    });

            inventory.Add(new Inventory
            {
                Item = 24,
                Description = "Power saw",
                Quantity = 18,
                Price = 99.99,
            });

            inventory.Add(new Inventory
            {
                Item = 7,
                Description = "Sledge hammer",
                Quantity = 11,
                Price = 21.55,
            });

            inventory.Add(new Inventory
            {
                Item = 77,
                Description = "Hammer",
                Quantity = 76,
                Price = 11.99,
            });

            inventory.Add(new Inventory
            {
                Item = 39,
                Description = "Lawn mower",
                Quantity = 3,
                Price = 79.95,
            });

            inventory.Add(new Inventory
            {
                Item = 68,
                Description = "Screwdriver",
                Quantity = 106,
                Price = 7.99,
            });

            inventory.Add(new Inventory
            {
                Item = 56,
                Description = "Jig Saw",
                Quantity = 21,
                Price = 11.95,
            });

            inventory.Add(new Inventory
            {
                Item = 3,
                Description = "Wrench",
                Quantity = 34,
                Price = 7.95,
            });
            
        }

        public static double MaxPrice()
        {
            double theMaxPrice = inventory.Max(s => s.Price);
            return theMaxPrice;
        }

 
        public static List<Inventory> GetInventory()
        {
            return inventory.ToList<Inventory>();
        }
        }
    }
