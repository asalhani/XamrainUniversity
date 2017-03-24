using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace AndroidSample01
{
    [Activity(Label = "Android Sample - 01", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnCalculate;
        EditText txtBill;
        TextView lblTip;
        TextView lblTotal;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            txtBill = FindViewById<EditText>(Resource.Id.txtBill);
            lblTip = FindViewById<TextView>(Resource.Id.lblTip);
            lblTotal = FindViewById<TextView>(Resource.Id.lblTotal);
            btnCalculate = FindViewById<Button>(Resource.Id.btnCalculate);

            btnCalculate.Click += onCalculateClick;
        }

        void onCalculateClick (object sender, EventArgs e)
        {
            string strBill = txtBill.Text;
            var bill = double.Parse(strBill);

            double tip = bill * 0.15;
            double total = bill + tip;

            lblTip.Text = tip.ToString();
            lblTotal.Text = total.ToString();
        }
    }
}

