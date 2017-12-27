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
using Groceries.Droid.Classes;

namespace Groceries.Droid
{
    [Activity(Label = "ListsActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class ListsActivity : Activity
    {

        Button newListButton;
        ListView groceryListView;
        Button profileButton;
        ListRowCustomAdapter groceryAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListsLayout);
            interfaceBuilder();


            AppData.GetInstance();
            AppData.currentUser = new UserClass()
            {
                Name = "Soumik",
                Email = "defEmail",
                Uid = "defUid"
            };

            PrepareFirstLists.Prepare();

            groceryAdapter = new ListRowCustomAdapter(this, AppData.currentLists);
            groceryListView.Adapter = groceryAdapter;

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