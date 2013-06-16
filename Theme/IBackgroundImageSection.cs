using System;
using MonoTouch.UIKit;

namespace BigTed.Theme
{
	public interface IBackgroundImageSection
	{
		UITableViewCell CustomizeCell (UITableViewCell cell, MonoTouch.Foundation.NSIndexPath indexPath, UITableViewStyle style);


	}
}

