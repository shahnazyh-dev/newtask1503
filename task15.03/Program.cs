namespace task15._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            while (true)
            {
                Console.WriteLine("****MENU***");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Remove product by No");
                Console.WriteLine("3. Get product by No");
                Console.WriteLine("4. Filter products by type");
                Console.WriteLine("5. Filter products by name");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice:");
                 string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Price: ");
                        double price = double.Parse(Console.ReadLine());

                        Console.WriteLine("Choose Type: 0-Baker, 1-Drink, 2-Meat, 3-Diary");
                        Type Type = (Type)int.Parse(Console.ReadLine());

                        Product product = new Product(name, price, Type);
                        store.AddProduct(product);
                        Console.WriteLine("Product added successfully!");
                        break;

                    case "2":
                        Console.Write("Enter Product No: ");
                        int noRemove = int.Parse(Console.ReadLine());
                        store.RemoveProductByNo(noRemove);
                        Console.WriteLine("Product removed!");
                        break;

                    case "3":
                        Console.Write("Enter Product No: ");
                        int noGet = int.Parse(Console.ReadLine());
                        var productGet = store.GetProduct(noGet);
                        if (productGet != null)
                            Console.WriteLine(productGet);
                        else
                            Console.WriteLine("Product not found!");
                        break;

                    case "4":
                        Console.WriteLine("Choose Type: 0-Baker, 1-Drink, 2-Meat, 3-Diary");
                        Type  typeFilter = (Type )int.Parse(Console.ReadLine());
                        var filteredByType = store.FilterProductsByType(typeFilter);
                        foreach (var p in filteredByType) Console.WriteLine(p);
                        break;

                    case "5":
                        Console.Write("Enter Name keyword: ");
                        string nameFilter = Console.ReadLine();
                        var filteredByName = store.FilterProductByName(nameFilter);
                        foreach (var p in filteredByName) Console.WriteLine(p);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;




                }


            }
        }
    }
}
