using System;

using Xamarin.Forms;
using FreshMvvm;

namespace FreshMVVMSample
{
	public class App : Application
	{
		public App ()
		{
			FreshIOC.Container.Register<IActivityService, ActivityService> ();
			var tabbedNavigation = new FreshTabbedNavigationContainer ();
			tabbedNavigation.AddTab<ActivityListPageModel> ("Activities", null);
			MainPage = tabbedNavigation;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

