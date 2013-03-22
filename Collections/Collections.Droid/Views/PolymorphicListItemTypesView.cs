using Android.App;
using Android.Content;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;
using Collections.Core.ViewModels.Samples.ListItems;
using Collections.Core.ViewModels.Samples.MultipleListItemTypes;

namespace Collections.Droid.Views
{
    [Activity(Label = "Polymorphic Types", ScreenOrientation = ScreenOrientation.Portrait)]
    public class PolymorphicListItemTypesView : MvxActivity
    {
        public new PolymorphicListItemTypesViewModel ViewModel
        {
            get { return (PolymorphicListItemTypesViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_PolymorphicView);
            var list = FindViewById<MvxListView>(Resource.Id.TheListView);
            list.Adapter = new CustomAdapter(this, (IMvxAndroidBindingContext)BindingContext);
        }

        public class CustomAdapter : MvxAdapter
        {
            public CustomAdapter(Context context, IMvxAndroidBindingContext bindingContext)
                : base(context, bindingContext)
            {
            }

            protected override Android.Views.View GetBindableView(Android.Views.View convertView, object source, int templateId)
            {
                if (source is Kitten)
                    templateId = Resource.Layout.ListItem_Kitten;
                else if (source is Dog)
                    templateId = Resource.Layout.ListItem_Dog;

                return base.GetBindableView(convertView, source, templateId);
            }
        }
    }
}