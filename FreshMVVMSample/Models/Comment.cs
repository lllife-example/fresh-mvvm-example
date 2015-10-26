using System;
using PropertyChanged;

namespace FreshMVVMSample
{
	[ImplementPropertyChanged]
	public class Comment
	{
		public Comment ()
		{
		}

		public int Id { get; set; }
		public User User { get; set; }
		public string Body { get; set; }

	}
}

