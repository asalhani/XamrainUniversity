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
    [Activity(Label = "AddItemActivity")]
    public class AddItemActivity : Activity
    {
        EditText txtItemName;
        EditText txtItemCount;
        Button btnSave;
        Button btnCancel;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddItem);

            InitiViews();

            btnCancel.Click += BtnCancel_Click;
            btnSave.Click += BtnSave_Click;
            // Create your application here
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var resultIntent = new Intent();
            resultIntent.PutExtra("ItemName", txtItemName.Text);
            resultIntent.PutExtra("ItemCount", Convert.ToInt32(txtItemCount.Text));
            SetResult(Result.Ok, resultIntent);
            Finish();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void InitiViews()
        {
            txtItemName = FindViewById<EditText>(Resource.Id.txtItemName);
            txtItemCount = FindViewById<EditText>(Resource.Id.txtItemCount);
            btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnCancel = FindViewById<Button>(Resource.Id.btnCancel);
        }
    }
}