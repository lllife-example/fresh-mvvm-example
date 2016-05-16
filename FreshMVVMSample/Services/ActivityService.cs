using System;
using System.Collections.Generic;

namespace FreshMVVMSample
{
	public class ActivityService : IActivityService
	{
		private List<Activity> _activities;

		public ActivityService ()
		{
			var user1 = new User { Id = 1, Name = "Richard", Email = "richard@richardedwards.ca" };
			var user2 = new User { Id = 2, Name = "wk", Email = "somnuk.wk@gmail.com" };

			_activities = new List<Activity> {
				new Activity {
					Id=1,
					Title="FreshMvvm is designed to be easy and simple. So getting started is also fairly simple.",
					User = user1,
					Comments = new List<Comment> {
						new Comment { Id=100, User=user1, Body = "Really like this!" },
						new Comment { Id=101, User=user2, Body = "Me too!" }
					}
				} ,
				new Activity {
					Id=200,
					Title="I’m very much enjoy your Mvvm implementation.",
					User = user2,
					Comments = new List<Comment> {
						new Comment { Id=2, User=user2, Body = "Wow, look at that" }
					}
				}
			};

		}

		public System.Collections.Generic.IEnumerable<Activity> GetActivities ()
		{
			return _activities;
		}
	}
}

