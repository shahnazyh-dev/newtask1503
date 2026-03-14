using System;
using System.Collections.Generic;
using System.Text;

namespace task15._03
{
    internal class Product
    {
        private static int _Counter = 0;
        public int No { get; }
        public string Name { get; }

        private double _qiymet;
        public double qiymet
        {
            get
            {
                return _qiymet;
            }
            set
            {
                if (value < 0)
                {
                    throw new PriceMustBeGreaterThanZeroException("Qiymet menfi ola bilmez");
                }
                else
                {
                    _qiymet = value;
                }
            }
        }
        public Type Type { get; }
        public Product(string name, double price, Type type)
        {
            No = ++_Counter;
            Name = name;
            qiymet = price;
            Type = type;
        }
        public override string ToString()
        {
            return $"No: {No} Name: {Name} Price: {qiymet} Type: {Type}";
        }
    }
}