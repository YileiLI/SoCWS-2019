using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace VelibClient
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;
        TextView textMessage1;
        TextView textMessage2;
        TextView textMessage3;
        FrameLayout myfragment;
        MyFragment f2, f3;
        cityFragment f1;
        FragmentManager manager;
        FragmentTransaction transaction;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            transaction = FragmentManager.BeginTransaction();
            myfragment = (FrameLayout)FindViewById(Resource.Id.myfragment);
            textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
            cityFragment f = new cityFragment();
            //MyFragment f = new MyFragment();
            transaction.Add(Resource.Id.myfragment, f);
            transaction.Commit();
        }

        private void hideAllFragment(FragmentTransaction fragmentTransaction)
        {
            if (f1 != null) fragmentTransaction.Hide(f1);
            if (f2 != null) fragmentTransaction.Hide(f2);
            if (f3 != null) fragmentTransaction.Hide(f3);
        }


        public bool OnNavigationItemSelected(IMenuItem item)
        {
            transaction = FragmentManager.BeginTransaction();
            hideAllFragment(transaction);
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    if (f1 == null)
                    {
                        f1 = new cityFragment();
                        transaction.Add(Resource.Id.myfragment, f1);
                    }
                    else
                    {
                        transaction.Show(f1);
                    }
                    break;
                case Resource.Id.navigation_dashboard:
                    if (f2 == null)
                    {
                        f2 = new MyFragment();
                        transaction.Add(Resource.Id.myfragment, f2);
                    }
                    else
                    {
                        transaction.Show(f2);
                    }
                    break;
                //textMessage.SetText(Resource.String.title_dashboard);
                //return true;
                case Resource.Id.navigation_notifications:
                    // textMessage.SetText(Resource.String.title_notifications);
                    // return true;
                    if (f3 == null)
                    {
                        f3 = new MyFragment();
                        transaction.Add(Resource.Id.myfragment, f3);
                    }
                    else
                    {
                        transaction.Show(f3);
                    }
                    break;
            }
            transaction.Commit();
            return false;
        }
    }
}

