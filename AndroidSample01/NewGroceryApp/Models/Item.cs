using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NewGroceryApp.Models
{
    public class Item
    {
        public Item(string name, int count)
        {
            this.Count = count;
            this.Name = name;
        }

        public int Count { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}