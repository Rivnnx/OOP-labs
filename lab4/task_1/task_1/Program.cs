using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
// зберігання інформації  
    struct StoreInfo
    {
        public int MaxItemsCardNumber;
        public int MaxItemsBought;

        public int MaxSpentCardNumber;
        public decimal MaxSpentMoney;
    }
    // товар 
    class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
    // покупці
    class Customer
    {
        public int CardNumber;
        public decimal Money;
        public int ItemsBought;
        public decimal TotalSpent;

        public Customer(int cardNumber, decimal money)
        {
            CardNumber = cardNumber;
            Money = money;
            ItemsBought = 0;
            TotalSpent = 0;

        }
    }

    // магазин 
    class Store
    {
        public List<Product> Inventory;
        public decimal TotalProfit;

        public Store()
        {
            Inventory = new List<Product>
            {
                new Product("Хліб", 30, 50),
                new Product("Молоко", 45, 30),
                new Product("Смартфон", 8500, 5),
                new Product("Навушники", 1500, 10),
                new Product("Кола", 25, 100),
                new Product("Шоколад", 60, 40)
            };
            TotalProfit = 0;
        }

        // процес покупок 
        public void ProcessCustomer(Customer customer, Random rnd)
        {
            while (true)
            {
                List<Product> affordableProducts = new List<Product>();
                foreach (var product in Inventory)
                {
                    if (product.Quantity > 0 && customer.Money >= product.Price)
                    {
                        affordableProducts.Add(product);
                    }
                }

                if (affordableProducts.Count == 0)
                {
                    break;
                }

                int randomIndex = rnd.Next(affordableProducts.Count);
                Product chosenProduct = affordableProducts[randomIndex];

                customer.Money -= chosenProduct.Price;
                customer.TotalSpent += chosenProduct.Price;
                customer.ItemsBought++;

                chosenProduct.Quantity--;
                TotalProfit += chosenProduct.Price;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть кількість покупців: ");
            int customersCount = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            Store myStore = new Store();
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < customersCount; i++)
            {
                int card = rnd.Next(1, 1000);
                decimal startMoney = rnd.Next(1000, 10000);

                customers.Add(new Customer(card, startMoney));
            }

            foreach (var customer in customers)
            {
                myStore.ProcessCustomer(customer, rnd);
            }

            StoreInfo report = new StoreInfo();

            foreach (var customer in customers)
            {
                if (customer.ItemsBought > report.MaxItemsBought)
                {
                    report.MaxItemsBought = customer.ItemsBought;
                    report.MaxItemsCardNumber = customer.CardNumber;
                }

                if (customer.TotalSpent > report.MaxSpentMoney)
                {
                    report.MaxSpentMoney = customer.TotalSpent;
                    report.MaxSpentCardNumber = customer.CardNumber;
                }
            }

            // result
            Console.WriteLine("\n РЕЗУЛЬТАТИ");
            Console.WriteLine($"Прибуток магазину: {myStore.TotalProfit}");

            if (report.MaxItemsBought > 0)
            {
                Console.WriteLine($"Покупець, що купив найбільше товарів: Картка №{report.MaxItemsCardNumber} ({report.MaxItemsBought} шт.)");
                Console.WriteLine($"Покупець, що витратив найбільше грошей: Картка №{report.MaxSpentCardNumber} ({report.MaxSpentMoney} грн)");
            }
        }
    }
}