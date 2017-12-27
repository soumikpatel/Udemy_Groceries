using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Groceries.Droid.Classes
{
    public class ListRowCustomAdapter : BaseAdapter<GroceryListClass>
    {

        readonly List<GroceryListClass> currentLists;
        readonly Activity myContext;

        public override GroceryListClass this[int position]
        {
            get
            {
                return currentLists[position];
            }
        }

        public ListRowCustomAdapter(Activity context, List<GroceryListClass> inpLists) :base()
        {
            this.myContext = context;
            this.currentLists = inpLists;
        }


        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return currentLists.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = myContext.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            var pixelToDP = (int)Android.Content.Res.Resources.System.DisplayMetrics.Density;

            view.SetMinimumHeight(96 * pixelToDP);

            TextView MainTextView = view.FindViewById< TextView > (Android.Resource.Id.Text1);
            MainTextView.Text = currentLists[position].Name;
            MainTextView.TextSize = 22;
            MainTextView.SetTypeface(null, TypefaceStyle.Bold);

            string subText = currentLists[position].Items.Count.ToString() + " for " + currentLists[position].Owner.Name;

            TextView subTextView = view.FindViewById<TextView>(Android.Resource.Id.Text2);
            subTextView.Text = subText;
            subTextView.SetTextColor(Color.DarkGray);

            if (position % 2 == 0)
            {
                view.SetBackgroundColor(Color.Rgb(230,230,230));
            }

            else
            {
                view.SetBackgroundColor(Color.Transparent);
            }
            return view;
        }
        
    }
}