using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace BigTed.Theme
{
	public class BTRootElement : RootElement
	{
		public BTRootElement (string caption) : base (caption)
		{
	
		}

		public BTRootElement (string caption, Func<RootElement, UIViewController> createOnSelected) : base (caption, createOnSelected)
		{
		}
		public 	BTRootElement (string caption, int section, int element) : base (caption, section, element)
		{
		}
		public BTRootElement (string caption, Group group) : base (caption, @group)
		{
		}

		static NSString cellKey = new NSString("BTRootElement");
		protected override NSString CellKey
		{
			get
			{
				return cellKey;
			}
		}

		protected override MonoTouch.UIKit.UIViewController MakeViewController ()
		{
			if (createOnSelected != null)
				return createOnSelected (this);

			return new BTDialogViewController (this, true) { Autorotate = true };
		}
	}
}

