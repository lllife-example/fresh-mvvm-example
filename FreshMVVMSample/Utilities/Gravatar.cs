using System;
using System.Text;
using System.Linq;

namespace FreshMVVMSample
{
	public class Gravatar
	{
		static JeffWilcox.Utilities.Silverlight.MD5 md5;

		static Gravatar ()
		{
			// MD5 not available in PCL, using an open-source implementation
			md5 = JeffWilcox.Utilities.Silverlight.MD5.Create ("MD5");
		}

		public static Uri GetImageUrl (string email, int size)
		{
			if (string.IsNullOrEmpty (email)) {
				throw new ArgumentException ("Email must be a valid email address.", "email");
			}
			if (size <= 0) {
				throw new ArgumentException ("Size must be greater than 0.", "size");
			}

			var hash = md5.ComputeHash (Encoding.UTF8.GetBytes (email.Trim ()));
			var hashString = string.Join ("", hash.Select (x => x.ToString ("x2")));
			return new Uri ("http://www.gravatar.com/avatar/" + hashString + ".jpg?s=" + size + "&d=mm");
		}
	}
}

