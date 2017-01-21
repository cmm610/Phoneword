using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace Phoneword
{
	[Activity (Label = "Phoneword", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		static readonly List<string> questions = DisneyTest.getQuestions();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.Main);

			Button disneyTestButton = FindViewById<Button>(Resource.Id.DisneyTestButton);

			disneyTestButton.Click += (object sender, EventArgs e) =>
			{
				Intent disneyTestIntent = new Intent(this, typeof(DisneyTestActivity));
				disneyTestIntent.PutStringArrayListExtra("questions", questions);
				StartActivity(disneyTestIntent);
			};

			//callButton.Click += (object sender, EventArgs e) =>
			//{
			//	// On "Call" button click, try to dial phone number.
			//	var callDialog = new AlertDialog.Builder(this);
			//	callDialog.SetMessage("Call " + translatedNumber + "?");
			//	callDialog.SetNeutralButton("Call", delegate {
			//		// Create intent to dial phone
			//		var callIntent = new Intent(Intent.ActionCall);
			//		callIntent.SetData(Android.Net.Uri.Parse("tel:" + translatedNumber));
			//		StartActivity(callIntent);
			//	});
			//	callDialog.SetNegativeButton("Cancel", delegate { });

			//	// Show the alert dialog to the user and wait for response.
			//	callDialog.Show();
			//};
		}
	}
}


