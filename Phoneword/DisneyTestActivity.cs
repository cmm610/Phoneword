using System;
using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Widget;

namespace Phoneword {
	[Activity(Label = "@string/disneyTest")]
	public class DisneyTestActivity : ListActivity {
		
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			var questions = Intent.Extras.GetStringArrayList("questions") ?? new string[0];
			this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, questions);
		}
	}
}
