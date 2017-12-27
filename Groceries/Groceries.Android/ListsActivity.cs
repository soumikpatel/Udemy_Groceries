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

namespace Groceries.Droid
{
    [Activity(Label = "ListsActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class ListsActivity : Activity
    {

        Button newListButton;
        ListView groceryListView;
        Button profileButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListsLayout);
            interfaceBuilder();

            string[] countries = new string[] {"USA", "Canada", "Mexico", "Japan", "India", "China" };
            ArrayAdapter listAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, countries);
            groceryListView.Adapter = listAdapter;

        }

        void interfaceBuilder() { 
            newListButton = FindViewById<Button>(Resource.Id.newListButton_id);
            newListButton.Click += NewListAlertView;

            groceryListView = FindViewById<ListView>(Resource.Id.groceryListView_id);
            groceryListView.ItemClick += GotoItems;
            groceryListView.ItemLongClick += DeteleListAlert;

            profileButton = FindViewById<Button>(Resource.Id.profileButton_id);
            profileButton.Click += ProfileAction;

        }

        private void DeteleListAlert(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GotoItems(object sender, AdapterView.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProfileAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewListAlertView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}