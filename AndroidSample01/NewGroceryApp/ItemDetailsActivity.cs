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

namespace NewGroceryApp
{
    [Activity(Label = "ItemDetailsActivity")]
    public class ItemDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ItemDetails);

            var itemPosition = Intent.GetIntExtra("ItemPosition", -1);
            if(itemPosition >= 0)
            {
                var item = MainActivity.Items[itemPosition];
                FindViewById<TextView>(Resource.Id.lblItemName).Text = item.Name;
                FindViewById<TextView>(Resource.Id.lblItemCount).Text = item.Count.ToString();
            }
            
        }
    }
}