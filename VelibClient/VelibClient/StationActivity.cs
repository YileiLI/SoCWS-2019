using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using VelibClient.Adapter;
using VelibClient.VelibServer;

namespace VelibClient
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class StationActivity : AppCompatActivity
    {
        static VelibServiceClient client = new VelibServiceClient();
        List<string> datas = new List<string>();
        string acity;
         protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.station_activity);
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            acity = prefs.GetString("my_data", "");
            SetUpList(acity);
            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView1);
            recyclerView.HasFixedSize = false;
            var layoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutManager);

            RecyclerAdapter adapter = new RecyclerAdapter(datas, this);
            recyclerView.SetAdapter(adapter);
        }

        private void SetUpList(string city)
        {
            string res = client.GetAllStationsByCity(city);
            datas = res.Split('\n').ToList();
        } 
    }
}