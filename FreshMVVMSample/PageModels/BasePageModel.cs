using System;
using FreshMvvm;
using PropertyChanged;

namespace FreshMVVMSample
{
	[ImplementPropertyChanged]
	public class BasePageModel : FreshBasePageModel
	{
		public BasePageModel ()
		{
		}

		public string Title { get; set; }
	}
}

