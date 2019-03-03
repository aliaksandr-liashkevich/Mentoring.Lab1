using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using ClassLibraryNetStandard;

namespace AppHelloAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var button = FindViewById<Button>(Resource.Id.helloButton);

            button.Click += (sender, args) =>
            {
                var userName = FindViewById<TextInputEditText>(Resource.Id.userNameTextBox).Text;
                var output = FindViewById<TextView>(Resource.Id.outputTextView);
                output.Text = User.SayHello(userName);
            };
        }
    }
}

