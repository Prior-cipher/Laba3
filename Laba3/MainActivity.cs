using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Laba3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        int count = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            var b = Resource.Id.button1;
            var c = FindViewById(Resource.Id.button1);
            Button button = FindViewById<Button>(Resource.Id.button1);
                //FindViewById<Button>(Resource.Id.button1);
            button.Click += Button_Click;

            SetContentView(Resource.Layout.activity_main);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void Button_Click(object sender, EventArgs e)
        {
            EditText t = FindViewById<EditText>(Resource.Id.textView1);
            t.Text = count.ToString();
            count++;
        }
    }
}