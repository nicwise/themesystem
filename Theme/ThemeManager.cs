using System;
using MonoTouch.UIKit;

namespace BigTed.Theme
{
	public class ThemeManager
	{
		public static void ApplyTheme()
		{
			UINavigationBar.Appearance.SetBackgroundImage(Resources.NavBarHeader, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackgroundImage(Resources.NavBarButton, UIControlState.Normal, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackgroundImage(Resources.NavBarButton, UIControlState.Highlighted, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackButtonBackgroundImage(Resources.NavBarBackButton, UIControlState.Normal, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackButtonBackgroundImage(Resources.NavBarBackButton, UIControlState.Highlighted, UIBarMetrics.Default);

			UISearchBar.Appearance.BackgroundImage = Resources.SearchBackground;
			UISearchBar.Appearance.SetSearchFieldBackgroundImage(Resources.SearchBackground, UIControlState.Normal);

			UITabBar.Appearance.SelectionIndicatorImage = Resources.TabBarSelected;
			UITabBar.Appearance.BackgroundImage = Resources.TabBarBackground;

			UISearchBar.Appearance.BackgroundImage = Resources.SearchBackground;
			UISearchBar.Appearance.SetSearchFieldBackgroundImage(Resources.SearchBackground, UIControlState.Normal);

			var navBarAttributes = new UITextAttributes {
				TextColor = Colors.NavBarTitleColor,
				TextShadowColor = Colors.NavBarTitleShadowColor,
				TextShadowOffset = new UIOffset(0,-1)
			};
			UINavigationBar.Appearance.SetTitleTextAttributes (navBarAttributes);

			/*
			UITextAttributes cancelAttributes = new UITextAttributes();
			//cancelAttributes.TextShadowOffset = new UIOffset(0,-1);
			cancelAttributes.TextShadowColor = UIColor.White.ColorWithAlpha(0.8f);
			cancelAttributes.TextColor = Resources.CancelButtonEnabled;

			UIBarButtonItem.AppearanceWhenContainedIn(typeof(UISearchBar)).SetTitleTextAttributes(cancelAttributes, UIControlState.Normal);



			cancelAttributes = new UITextAttributes();
			//cancelAttributes.TextShadowOffset = new UIOffset(0, -1);
			cancelAttributes.TextShadowColor = UIColor.White.ColorWithAlpha(0.5f);
			cancelAttributes.TextColor = Resources.CancelButtonDisabled;

			UIBarButtonItem.AppearanceWhenContainedIn(typeof(UISearchBar)).SetTitleTextAttributes(cancelAttributes, UIControlState.Disabled);
*/
		}
	}
}

