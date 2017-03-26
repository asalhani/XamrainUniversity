﻿using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using NewGroceryApp.Models;
using System;
using Android.Content;
using Android.Runtime;

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
            btnAddItem.Click += BtnAddItem_Click;


        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if(requestCode == 100 && resultCode == Result.Ok)
            {
                var itemName = data.GetStringExtra("ItemName");
                var itemCount = data.GetIntExtra("ItemCount", -1);

                Items.Add(new Item(itemName, itemCount));
                StartActivity(typeof(ListItemsActivity));
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            StartActivityForResult(typeof(AddItemActivity), 100);
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

