using System;
using PropertyChanged;
using FreshMvvm;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FreshMVVMSample
{
	[ImplementPropertyChanged]
	public class ActivityListPageModel : BasePageModel
	{
		IActivityService _activityService;

		public ActivityListPageModel (IActivityService activityService)
		{
			_activityService = activityService;
			Title = "Activities";
		}

		public ObservableCollection<Activity> Activities { get; set; }

		public override void Init (object initData)
		{
			Activities = new ObservableCollection<Activity> (_activityService.GetActivities ());
		}

		// Methods are automatically wired up to page
		protected override void ViewIsAppearing (object sender, System.EventArgs e)
		{
			//CoreMethods.DisplayAlert ("Page is appearing", "", "Ok");
			base.ViewIsAppearing (sender, e);
		}

		protected override void ViewIsDisappearing (object sender, System.EventArgs e)
		{
			base.ViewIsDisappearing (sender, e);
		}

		// This is called when a page id pop'd
		public override void ReverseInit (object value)
		{
			var activity = value as Activity;

			if (Activities.Contains (activity)) {
				Activities [Activities.IndexOf (activity)] = activity;
			}
		}

		public Command<Activity> ViewComments {
			get {
				return new Command<Activity> (async (activity) => {
					//await CoreMethods.PushPageModel<CommentListPageModel> (activity, true);
					await CoreMethods.PushPageModelWithNewNavigation<CommentListPageModel> (activity, true);
					//await CoreMethods.DisplayAlert ("Going to comments", activity.Title, "Ok");
				});
			}
		}


	}
}

