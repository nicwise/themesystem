using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace BigTed.Theme
{
	public class ThemeManager
	{

		public static UIButton CreateNormalButton(...)
		{

		}


		public static void ApplyTheme()
		{
			UINavigationBar.Appearance.SetBackgroundImage(Resources.NavBarHeader, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackgroundImage(Resources.NavBarButton, UIControlState.Normal, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackgroundImage(Resources.NavBarButtonHighlighted, UIControlState.Selected, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackgroundImage(Resources.NavBarButtonHighlighted, UIControlState.Highlighted, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackButtonBackgroundImage(Resources.NavBarBackButton, UIControlState.Normal, UIBarMetrics.Default);
			UIBarButtonItem.Appearance.SetBackButtonBackgroundImage(Resources.NavBarBackButton, UIControlState.Highlighted, UIBarMetrics.Default);

			UISearchBar.Appearance.BackgroundImage = Resources.SearchBackground;
			UISearchBar.Appearance.SetSearchFieldBackgroundImage(Resources.SearchBackground, UIControlState.Normal);

			UITabBar.Appearance.SelectionIndicatorImage = Resources.TabBarSelected;
			UITabBar.Appearance.BackgroundImage = Resources.TabBarBackground;

			UISearchBar.Appearance.BackgroundImage = Resources.SearchBackground;
			UISearchBar.Appearance.SetSearchFieldBackgroundImage(Resources.SearchBackground, UIControlState.Normal);

			UISlider.Appearance.SetThumbImage (Resources.SliderThumb, UIControlState.Normal);
			UISlider.Appearance.SetThumbImage (Resources.SliderThumb, UIControlState.Highlighted);
			UISlider.Appearance.SetMinTrackImage (Resources.SliderMinBackground, UIControlState.Normal);
			UISlider.Appearance.SetMaxTrackImage (Resources.SliderMaxBackground, UIControlState.Normal);



			var navBarAttributes = new UITextAttributes {
				TextColor = Colors.NavBarTitleColor,
				TextShadowColor = Colors.NavBarTitleShadowColor,
				TextShadowOffset = new UIOffset(0,-1)
			};
			UINavigationBar.Appearance.SetTitleTextAttributes (navBarAttributes);

			UIProgressView.Appearance.TrackImage = Resources.ProgressTrackBackground;
			UIProgressView.Appearance.ProgressImage = Resources.ProgressBackground;

			//UIButton.Appearance.SetBackgroundImage (Resources.Button, UIControlState.Normal);
			//UIButton.Appearance.SetBackgroundImage (Resources.ButtonHighlighted, UIControlState.Highlighted);

			/*
			 * UIImage *segmentSelected = [[UIImage imageNamed:@"segcontrol_sel.png"] resizableImageWithCapInsets:UIEdgeInsetsMake(0, 4, 0, 4)];
    UIImage *segmentUnselected = [[UIImage imageNamed:@"segcontrol_uns.png"] resizableImageWithCapInsets:UIEdgeInsetsMake(0, 15, 0, 15)];
    UIImage *segmentSelectedUnselected = [UIImage imageNamed:@"segcontrol_sel-uns.png"];
    UIImage *segUnselectedSelected = [UIImage imageNamed:@"segcontrol_uns-sel.png"];
    UIImage *segmentUnselectedUnselected = [UIImage imageNamed:@"segcontrol_uns-uns.png"];
    
    [[UISegmentedControl appearance] setBackgroundImage:segmentUnselected forState:UIControlStateNormal barMetrics:UIBarMetricsDefault];
    [[UISegmentedControl appearance] setBackgroundImage:segmentSelected forState:UIControlStateSelected barMetrics:UIBarMetricsDefault];
    
    [[UISegmentedControl appearance] setDividerImage:segmentUnselectedUnselected forLeftSegmentState:UIControlStateNormal rightSegmentState:UIControlStateNormal barMetrics:UIBarMetricsDefault];
    [[UISegmentedControl appearance] setDividerImage:segmentSelectedUnselected forLeftSegmentState:UIControlStateSelected rightSegmentState:UIControlStateNormal barMetrics:UIBarMetricsDefault];
    [[UISegmentedControl appearance] setDividerImage:segUnselectedSelected forLeftSegmentState:UIControlStateNormal rightSegmentState:UIControlStateSelected barMetrics:UIBarMetricsDefault];

*/

		}
	}
}

