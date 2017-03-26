using Android.App;
using Android.Widget;
using Android.OS;
using XamarinUniversity;

namespace ListViewApp
{
    [Activity(Label = "ListViewApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            var instructorListView = FindViewById<ListView>(Resource.Id.InstructorListView);

            //var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, InstructorData.Instructors);

            var instructorAdapter = new InstructorAdapter(this, InstructorData.Instructors);
            instructorListView.Adapter = instructorAdapter;

            instructorListView.ItemClick += InstructorListView_ItemClick;
        }

        private void InstructorListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        { 
            var item = InstructorData.Instructors[e.Position];
            var dialog = new AlertDialog.Builder(this);
            dialog.SetMessage(item.Name);
            dialog.SetNegativeButton("OK", delegate { });
            dialog.Show();
        }
    }
}

