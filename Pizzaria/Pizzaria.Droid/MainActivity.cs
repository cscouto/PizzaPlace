﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Pizzaria.Droid
{
	[Activity (Label = "Pizzaria", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            global::Xamarin.FormsMaps.Init(this, bundle);
            global::Xamarin.Forms.Forms.Init (this, bundle);
            
			LoadApplication (new Pizzaria.App ());
		}
	}
}
