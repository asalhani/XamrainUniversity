using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace YouTubeCourse
{
    [Activity(Label = "YouTubeCourse", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var listView = FindViewById<ListView>(Resource.Id.myListView);
            List<string> list = new List<string>();
            list.Add("Adeeb");
            list.Add("Ahmad");

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, list);
            listView.Adapter = adapter;
        }
    }
}

