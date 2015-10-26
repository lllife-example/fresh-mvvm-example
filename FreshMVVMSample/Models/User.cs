using System;
using PropertyChanged;

namespace FreshMVVMSample
{
	[ImplementPropertyChanged]
	public class User
	{
		public User ()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public Uri GravatarUrl {
			get {
				return Gravatar.GetImageUrl (Email, 100);
			}
		}

	}
}

