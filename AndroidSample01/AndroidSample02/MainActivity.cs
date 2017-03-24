using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;

namespace AndroidSample02
{
    [Activity(Label = "Adib Grocery App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static List<Item> Items = new List<Item>();

        Button btnListItems;
        Button btnAbout;

        protected override void OnCreate(Bundle bundle)
        {
            
            Items.Add(new Item("Milk", 2));
            Items.Add(new Item("Crackers", 1));
            Items.Add(new Item("Apples", 5));

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            btnAbout = FindViewById<Button>(Resource.Id.btnAbout);
            btnAbout.Click += BtnAbout_Click;

            btnListItems = FindViewById<Button>(Resource.Id.btnListItems);
            btnListItems.Click += BtnListItems_Click;

        }

        private void BtnListItems_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(ListItemsActivity));
            StartActivity(intent);
        }

        private void BtnAbout_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(AboutActivity));
        }
    }
}

