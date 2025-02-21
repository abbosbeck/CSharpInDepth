using System.Collections;

namespace Part2
{
    class Collections
    {
        public static void CollocationIenumrable()
        {
            // Create an initial list of orders.
            List<Order> orders = new List<Order>
        {
            new Order { Id = 1, Amount = 50 },
            new Order { Id = 1, Amount = 50 },
            new Order { Id = 1, Amount = 50 },
            new Order { Id = 1, Amount = 50 },
            new Order { Id = 2, Amount = 150 },
            new Order { Id = 3, Amount = 200 }
        };

            // Define the query using deferred execution.
            IEnumerable<Order> highValueOrders = orders.Where(o => o.Amount > 100);

            // At this point, the query has not been executed yet.
            Console.WriteLine("High value orders before adding a new order:");
            foreach (var order in highValueOrders)
            {
                Console.WriteLine($"Order {order.Id} with amount {order.Amount}");
            }

            // Add a new order that qualifies as high value.
            orders.Add(new Order { Id = 4, Amount = 300 });

            // Now, when we iterate again, the new order appears in the results.
            Console.WriteLine("\nHigh value orders after adding a new order:");
            foreach (var order in highValueOrders)
            {
                Console.WriteLine($"Order {order.Id} with amount {order.Amount}");
            }
        }

        public static void PrintElements<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }


    }

    internal class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
    }

    public class MyCustomCollection : IEnumerable<int>
    {
        private List<int> _data = new List<int>();
        public void Add(int item)
        {
            _data.Add(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
