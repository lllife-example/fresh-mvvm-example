using System;
using Xamarin.Forms;

namespace FreshMVVMSample
{
	public partial class ActivityListPage : ContentPage
	{
		public ActivityListPage ()
		{
			InitializeComponent ();
		}

		protected override void OnBindingContextChanged() {
			base.OnBindingContextChanged();

			if (this.Resources != null) {
				foreach (var resource in this.Resources.Values) {
					if (resource is BindableObject)
						((BindableObject) resource).BindingContext = this.BindingContext;
				}
			}

		}
	}
}

