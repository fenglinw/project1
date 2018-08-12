using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;
using Android.Runtime;

namespace Travaller_Map
{
	//change icon for this app.
	[Activity(Label = "@string/app_name",MainLauncher = true, Icon = "@drawable/ic", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);
			
			//gei the three button to access other activities.
			Button button_1 = FindViewByID<Button>(Resource.Id.button1);
			Button button_2 = FindViewByID<Button>(Resource.Id.button2);
			Button button_3 = FindViewByID<Button>(Resource.Id.button3);
			
			//load the first responce page when click the button1
			button_1.Click += delegate{
			Intent intent = new Intent(this,typeof(secondActivity));
			StartActivity(intent)
			}
			
			//load the second responce page when click the button1
			button_2.Click += delegate{
			Intent intent = new Intent(this,typeof(thirdActivity));
			StartActivity(intent)
			}
			
			
			//load the third responce page when click the button1
			button_3.Click += delegate{
			Intent intent = new Intent(this,typeof(forthActivity));
			StartActivity(intent)
			}
		
	}
}
