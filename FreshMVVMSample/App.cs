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

			//var page = FreshPageModelResolver.ResolvePageModel<ActivityListPageModel> ();
			//var basicNavContainer = new FreshNavigationContainer (page);
			//MainPage = basicNavContainer;

			var tabbedNavigation = new FreshTabbedNavigationContainer ();
			tabbedNavigation.AddTab<ActivityListPageModel> ("Activities", null);
			MainPage = tabbedNavigation;

//			MainPage = new NavigationPage(page);
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

