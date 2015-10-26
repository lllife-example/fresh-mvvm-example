using System;
using PropertyChanged;
using System.Collections.Generic;

namespace FreshMVVMSample
{
	[ImplementPropertyChanged]	
	public class Activity
	{
		public Activity ()
		{
		}

		public int Id { get; set; }
		public string Title { get; set; }
		public User User { get; set; }
		public List<Comment> Comments { get; set; }

	}
}

