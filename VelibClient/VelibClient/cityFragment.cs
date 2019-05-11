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
using Com.Toptoche.Searchablespinnerlibrary;

namespace VelibClient
{
    class cityFragment : Fragment
    {
        FragmentManager fm;
        CityDialogFragment cdf;
        ImageButton france, sweden, australia, spain;
        AlertDialog alertDialog = null;
        string city = null;
        public cityFragment()
        {

        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            fm = this.FragmentManager;

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.cityFragment, container, false);
            initButton(view);
            return view;
        }

        private void initButton(View view)
        {
            france = (ImageButton)view.FindViewById(Resource.Id.france);
            australia = (ImageButton)view.FindViewById(Resource.Id.australia);
            spain = (ImageButton)view.FindViewById(Resource.Id.spain);
            sweden = (ImageButton)view.FindViewById(Resource.Id.sweden);
            france.Click += delegate { onClick(france); };
            australia.Click += delegate { onClick(australia); };
            spain.Click += delegate { onClick(spain); };
            sweden.Click += delegate { onClick(sweden); };
        }

        private void onClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.france:
                    string[] frances = new string[] { "Toulouse", "Lyon", "Amiens", "Creteil", "Marseille", "Nancy" };
                    cdf = new CityDialogFragment(frances);
                    GetCities();
                    break;

                case Resource.Id.sweden:
                    string[] swedens = new string[] { "Lund", "Stockholm" };
                    cdf = new CityDialogFragment(swedens);
                    GetCities();
                    break;

                case Resource.Id.australia:
                    string[] australias = new string[] { "Brisbane" };
                    cdf = new CityDialogFragment(australias);
                    GetCities();
                    break;

                case Resource.Id.spain:
                    string[] spains = new string[] { "Santander" };
                    cdf = new CityDialogFragment(spains);
                    GetCities();
                    break;
            }
        }

        private void GetCities()
        {
            //show dialog
            cdf.Show(fm, "city");
        }
    }


}