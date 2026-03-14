using System;
using System.Collections.Generic;
using System.Text;

namespace task15._03
{
    internal class Store
    {
        private Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public void GetProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveProductByNo(int no)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    for (int j = i; j < products.Length - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    Array.Resize(ref products, products.Length - 1);
                    break;
                }
            }
        }
        public Product GetProduct(int no)
        {
          return Array.Find(products, p => p.No == no);
        }
        public Product[] FilterProductsByType(Type type)
        {
            return Array.FindAll(products, p => p.Type == type);
        }
        public Product[] FilterProductByName(string name)
        {
            return Array.FindAll(products, p => p.Name.Contains(name));
        }
    }
}