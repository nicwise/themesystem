using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace BigTed.Theme
{
	public class BTCustomCellSource : DialogViewController.Source
	{
		public BTCustomCellSource (DialogViewController container) : base(container)
		{
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = base.GetCell (tableView, indexPath);

			var section = Root [indexPath.Section];
			if (section is IBackgroundImageSection)
			{
				return (section as IBackgroundImageSection).CustomizeCell (cell, indexPath, Container.Style);
			}
			return cell;
		}


	}

	public class BTCustomCellSizingSource : DialogViewController.SizingSource
	{
		public BTCustomCellSizingSource(DialogViewController container) : base(container)
		{

		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = base.GetCell (tableView, indexPath);

			var section = Root [indexPath.Section];
			if (section is IBackgroundImageSection)
			{
				return (section as IBackgroundImageSection).CustomizeCell (cell, indexPath, Container.Style);
			}
			return cell;
		}
	}
}

