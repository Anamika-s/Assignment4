namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS FOR BRAND ");
            Product.DisplayBrand();
            List<Product> products = new List<Product>();
            List<Product> cart = new List<Product>();
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("WHo are you?" +
                    "\nEnter 1 for Admin\nENter 2 for Customer");
                int ch = byte.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:

                        {
                            int c = AdminMenu();
                            switch (c)
                            {
                                case 1:
                                    {
                                        string repeat = "y";
                                        while (repeat.Equals("y"))
                                        {
                                            Product product = new Product();
                                            product.GetDetails();
                                            products.Add(product);
                                            Console.WriteLine("add more product");
                                            repeat = Console.ReadLine();
                                        }
                                        break;
                                    }

                                case 2:
                                    {
                                        foreach (Product product in products)
                                        {
                                            product.DisplayDetails();

                                        }
                                        break;
                                    }


                            }
                            break;

                        }
                    case 2:
                        {
                            int c = CustomerMenu();
                            switch(c)
                            {

                                case 1:
                                    {
                                        string repeat = "y";
                                        while (repeat.Equals("y"))
                                        {
                                            Console.WriteLine("enter product to purchase");
                                            string productName = Console.ReadLine();
                                            Console.WriteLine("enter qty to purchase");
                                            int qty = byte.Parse(Console.ReadLine());

                                            foreach (Product product in products)
                                            {
                                                if (product.pName.Equals(productName))
                                                {
                                                    if (product.qtyInStock >= qty)
                                                    {
                                                        product.amount = qty * product.price;
                                                        product.DisplayDetails();
                                                        cart.Add(product);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Stock not available");
                                                    }
                                                }
                                            }
                                            Console.WriteLine("Purchase more?");
                                            repeat = Console.ReadLine();
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        int totalAmount=0;
                                        foreach(Product product in cart)
                                        {
                                            product.DisplayDetails();
                                            totalAmount += product.amount; 

                                        }
                                        Console.WriteLine("TOTAL AMOUNT IS " + totalAmount);    
                                        break;
                                    }
                            }
                            break;
                        }
                        Console.WriteLine("Repeat");
                        choice = Console.ReadLine();
                }

            }
            static int AdminMenu()
            {
                Console.WriteLine("Add Product");
                Console.WriteLine("Display Products");
                int ch = byte.Parse(Console.ReadLine());
                return ch;
            }
            static int CustomerMenu()
            {
                Console.WriteLine("Purchase Product");
                Console.WriteLine("Produce Bill");
                int ch = byte.Parse(Console.ReadLine());
                return ch;

            }
        }

        }

}