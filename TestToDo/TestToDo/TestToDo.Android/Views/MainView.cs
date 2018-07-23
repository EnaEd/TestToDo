using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;
using TestToDo.Core.Models;
using TestToDo.Core.ViewModels;

namespace TestToDo.Droid.Views
{
    [Activity(Label = "ListItems")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
            var listItems = ItemViewModel.ListItems;
            var list = FindViewById<ListView>(Resource.Id.listView1);
            var adapter = new ArrayAdapter<Item>(this, Android.Resource.Layout.SimpleListItem1, listItems);
            list.Adapter = adapter;
        }
        
        
    }
}
