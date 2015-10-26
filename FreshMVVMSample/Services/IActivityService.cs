using System;
using System.Collections.Generic;

namespace FreshMVVMSample
{
	public interface IActivityService
	{
		IEnumerable<Activity> GetActivities();

	}
}

