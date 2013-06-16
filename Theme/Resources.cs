using System;
using MonoTouch.UIKit;

namespace BigTed.Theme
{
	public static class Resources
	{
		public static UIImage TempIcon = UIImage.FromFile ("images/bear_head.png");

		public static UIImage CellBackgroundFull = UIImage.FromFile ("images/theme/cell-single-normal.png").CreateResizableImage (new UIEdgeInsets (5, 5, 5, 5));
		public static UIImage CellBackgroundFullSelected = UIImage.FromFile ("images/theme/cell-single-selected.png").CreateResizableImage(new UIEdgeInsets(5,5,5,5));

		public static UIImage CellBackgroundTop = UIImage.FromFile ("images/theme/cell-top-normal.png").CreateResizableImage (new UIEdgeInsets (5, 5, 2, 5));
		public static UIImage CellBackgroundTopSelected = UIImage.FromFile ("images/theme/cell-top-selected.png").CreateResizableImage (new UIEdgeInsets (5, 5, 2, 5));

		public static UIImage CellBackgroundBottom = UIImage.FromFile ("images/theme/cell-bottom-normal.png").CreateResizableImage (new UIEdgeInsets (0, 5, 5, 5));
		public static UIImage CellBackgroundBottomSelected = UIImage.FromFile ("images/theme/cell-bottom-selected.png").CreateResizableImage (new UIEdgeInsets (0, 5, 5, 5));

		public static UIImage CellBackgroundMiddle = UIImage.FromFile ("images/theme/cell-middle-normal.png").CreateResizableImage (new UIEdgeInsets (2, 5, 2, 5));
		public static UIImage CellBackgroundMiddleSelected = UIImage.FromFile ("images/theme/cell-middle-selected.png").CreateResizableImage (new UIEdgeInsets (2, 5, 2, 5));

		public static UIImage CellBackgroundPlain = UIImage.FromFile ("images/theme/cell-plain-normal.png").CreateResizableImage (new UIEdgeInsets (2, 5, 2, 5));
		public static UIImage CellBackgroundPlainSelected = UIImage.FromFile ("images/theme/cell-plain-selected.png").CreateResizableImage (new UIEdgeInsets (2, 5, 2, 5));


		public static UIImage NavBarHeader = UIImage.FromFile ("images/theme/navbar.png");
		public static UIImage NavBarButton = UIImage.FromFile ("images/theme/button-normal.png");
		public static UIImage NavBarBackButton = UIImage.FromFile ("images/theme/button-back.png");
		public static UIImage NavBarButtonSelected = UIImage.FromFile ("images/theme/button-selected.png");

		public static UIImage SearchBackground = UIImage.FromFile ("images/theme/searchbar-background.png");

		public static UIImage TabBarBackground = UIImage.FromFile ("images/theme/tabbar-background.png");
		public static UIImage TabBarSelected = UIImage.FromFile ("images/theme/tabbar-selected.png").CreateResizableImage(new UIEdgeInsets(5,5,5,5));

		public static UIImage SectionHeaderBackground = UIImage.FromFile ("images/theme/section-header.png");

	}
}

