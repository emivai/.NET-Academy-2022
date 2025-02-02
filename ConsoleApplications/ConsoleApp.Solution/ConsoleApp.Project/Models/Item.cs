﻿namespace ConsoleApp.Project.Models
{
    public class Item
    {
        public string Name { get; set; }

        public int Quantity { get; set; } = 1;

        public override string ToString()
        {
            return $"Name: {Name} Quantity: {Quantity}";
        }
    }
}
