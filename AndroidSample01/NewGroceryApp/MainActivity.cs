using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using NewGroceryApp.Models;
using System;

namespace NewGroceryApp
{
    [Activity(Label = "NewGroceryApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnListItems;
        Button btnAddItem;
        Button btnAbout;

        public static List<Item> Items = new List<Item>();

        protected override void OnCreate(Bundle bundle)
        {
            InitiateItems();

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            InitiateViewControls();

            btnAbout.Click += BtnAbout_Click;
            btnListItems.Click += BtnListItems_Click;


        }

        private void BtnListItems_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(ListItemsActivity));
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AboutActivity));
        }

        private void InitiateViewControls()
        {
            btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
            btnAddItem = FindViewById<Button>(Resource.Id.btnAddItem);
            btnListItems = FindViewById<Button>(Resource.Id.btnListItems);
        }

        private void InitiateItems()
        {
            Items.Add(new Item("Apple", 1));
            Items.Add(new Item("Bannana", 44));
            Items.Add(new Item("Orange", 18));
        }
    }
}

