using Foundation;
using UIKit;
using Xamarin.Forms;

namespace FreshMVVMSample.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	//public class AppDelegate : UIApplicationDelegate
	public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		// class-level declarations
		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method

			global::Xamarin.Forms.Forms.Init ();
			LoadApplication (new FreshMVVMSample.App ());
			return base.FinishedLaunching (application, launchOptions);
		}
	}
}


