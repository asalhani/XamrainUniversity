using System;
using System.Collections.Generic;
namespace AndroidSample02
{
    public class Item
    {
        public Item(string name, long count)
        {
            Name = name;
            Count = count;
        }

        public string Name { get; set; }
        public long Count { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}