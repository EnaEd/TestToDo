using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace TestToDo.Droid.Views
{
    [Activity(Label = "Item")]
    public class ItemView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ItemView);
        }
    }
}