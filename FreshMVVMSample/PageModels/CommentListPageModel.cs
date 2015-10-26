using System;
using PropertyChanged;
using FreshMvvm;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Generic;

namespace FreshMVVMSample
{
	[ImplementPropertyChanged]
	public class CommentListPageModel : BasePageModel
	{
		IActivityService _activityService;

		public CommentListPageModel (IActivityService activityService)
		{
			_activityService = activityService;
			Title = "Comments";
		}

		public Activity Activity { get; set; }

		public override void Init (object initData)
		{
			if (initData != null) {
				Activity = (Activity)initData;
			}
		}

		public Command CloseCommand {
			get { 
				return new Command (() => {
					//_dataService.UpdateContact (Contact);
					var user3 = new User { Id = 3, Name = "Bill Lott", Email = "bill@somewhere.com" };
					Activity.Comments.Add(new Comment {Id=101, User=user3, Body = "Just added this comment!" });

					CoreMethods.PopPageModel (Activity, true);
				}
				);
			}
		}
	}
}

