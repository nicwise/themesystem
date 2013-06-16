using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;

namespace BigTed.Theme
{
	public class BTDialogViewController : DialogViewController
	{
		public BTDialogViewController (RootElement root) : base(root)
		{
		}


		public BTDialogViewController (UITableViewStyle style, RootElement root) : base (style, root)
		{
		}

		public BTDialogViewController (RootElement root, bool pushing) : base (root, pushing)
		{
		}

		public BTDialogViewController (UITableViewStyle style, RootElement root, bool pushing) : base (style, root, pushing)
		{
		}

		public BTDialogViewController (IntPtr handle) : base(handle)
		{

		}

		public override UITableView MakeTableView (System.Drawing.RectangleF bounds, UITableViewStyle style)
		{
			var tv = base.MakeTableView (bounds, style);
			tv.BackgroundView = new UIView () { BackgroundColor = Colors.TableViewBackground };
			tv.SeparatorStyle = UITableViewCellSeparatorStyle.None;
			return tv;
		}


		public override Source CreateSizingSource (bool unevenRows)
		{
			if (!unevenRows)
				return new BTCustomCellSource (this);
			return new BTCustomCellSizingSource (this);
		}






	}


}

