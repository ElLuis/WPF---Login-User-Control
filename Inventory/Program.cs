using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string Desc;
            int Qty;
            //1.
            Console.WriteLine("Sorted by item description: \n");
            IEnumerable<Inventory> orderDescriptionQuery =
                from c in Inventory.GetInventory()
                orderby c.Description
                select c;

            foreach (Inventory i in orderDescriptionQuery)
            {
                Console.WriteLine("Item: {0}, {1}, Quantity: {2}, Price: {3}", i.Item,i.Description,i.Quantity,i.Price);
            }

            //2.
            Console.WriteLine("\nSorted by quantity\n ");
            var orderQuantityQuery =
                from b in Inventory.GetInventory()
                orderby b.Quantity
                select new
                {
                    Desc = b.Description,
                    Qty = b.Quantity
                };

            foreach (var v in orderQuantityQuery)
            {
                Console.WriteLine("{0}, Quantity: {1}", v.Desc,v.Qty);
            }

            //Description and total
            Console.WriteLine("\nSorted by total\n ");
            var orderTotalQuery =
                from b in Inventory.GetInventory()
                orderby b.Quantity * b.Price
                select new
                {
                    Desc = b.Description,
                    Qty = b.Quantity * b.Price
                };

            foreach (var v in orderTotalQuery)
            {
                Console.WriteLine("{0}, Total: ${1}", v.Desc, v.Qty);
            }

            //Most Expensive item
            Console.WriteLine("\nMost Expensive item\n ");
            var mostExpensive =
                from a in Inventory.GetInventory()
                where a.Price == Inventory.MaxPrice()
                select a;

            foreach (var h in mostExpensive)
            {
                Console.WriteLine("The most expensive item is: {0} ,price: ${1} ",h.Description, h.Price);
            }


            Console.ReadKey();
        }
    }
}
