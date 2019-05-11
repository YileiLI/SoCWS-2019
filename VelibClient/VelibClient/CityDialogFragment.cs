using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VelibClient
{
    class CityDialogFragment : DialogFragment
    {
        ListView lv;
        string[] cities;
        ArrayAdapter adapter;
        public CityDialogFragment(string[] cities)
        {
            this.cities = cities;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.list_cities, container);
            this.Dialog.SetTitle("Choose a city");
            lv = view.FindViewById<ListView>(Resource.Id.listView1);
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, cities);
            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

            return view;
        }

        private void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (cities[e.Position] != null)
            {
                ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Context);
                ISharedPreferencesEditor editor = prefs.Edit();
                editor.PutString("city", cities[e.Position]);
                editor.Apply();
                Intent intente = new Intent(Activity, typeof(StationActivity));
                StartActivity(intente);
            }
        }
    }
}