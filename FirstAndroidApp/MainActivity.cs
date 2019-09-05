using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace FirstAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public Button button1;
        public TextView textview1;
        public Toast toast;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            button1 = FindViewById<Button>(Resource.Id.CoolButton);
            button1.Click += CoolButtonClick;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public void CoolButtonClick(object sender, System.EventArgs e)
        {
            Intent CounterScreen = new Intent(this, typeof(CounterActivity));
            var toast = Toast.MakeText(Application.Context, "Nieuwe pagina", ToastLength.Long);
            toast.Show();
            StartActivity(CounterScreen);
            var toast1 = Toast.MakeText(Application.Context, "Nieuwe pagina test", ToastLength.Long);
            toast1.Show();
        }
    }
}