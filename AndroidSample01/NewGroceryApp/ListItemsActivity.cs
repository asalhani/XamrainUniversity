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
using NewGroceryApp.Models;

namespace NewGroceryApp
{
    [Activity(Label = "ListItemsActivity")]
    public class ListItemsActivity : Activity
    {
        ListView lstItems;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListItems);

            lstItems = FindViewById<ListView>(Resource.Id.lstItems);
            lstItems.Adapter = new ArrayAdapter<Item>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, MainActivity.Items);
            lstItems.ItemClick += LstItems_ItemClick;
            
        }

        private void LstItems_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(ItemDetailsActivity));
            intent.PutExtra("ItemPosition", e.Position);
            StartActivity(intent);
        }
    }
}