using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace FirstAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class CounterActivity : AppCompatActivity
    {
        TextView txtNumber;
        int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_counter);

            txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);
           

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            txtNumber.Text = (++number).ToString();


            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            txtNumber.Text = (--number).ToString();
        }
    }
}