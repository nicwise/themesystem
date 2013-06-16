using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace BigTed.Theme.Runner
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			ThemeManager.ApplyTheme ();

			var tabs = new UITabBarController ();



			var tabControllers = new UINavigationController[] {

				new UINavigationController(BuildDialogViewController()) {
					TabBarItem = new UITabBarItem("First", Theme.Resources.TempIcon, 1)
				},
				new UINavigationController(BuildDialogViewController(style: UITableViewStyle.Plain)) {
					TabBarItem = new UITabBarItem("Second", Theme.Resources.TempIcon, 1)
				},
				new UINavigationController(BuildDialogViewController()) {
					TabBarItem = new UITabBarItem("First", Theme.Resources.TempIcon, 1)
				},
				new UINavigationController(BuildDialogViewController(style: UITableViewStyle.Plain)) {
					TabBarItem = new UITabBarItem("Second", Theme.Resources.TempIcon, 1)
				}


			};

			tabs.SetViewControllers (tabControllers, false);

			
			// If you have defined a root view controller, set it here:
			window.RootViewController = tabs;
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}

		DialogViewController BuildDialogViewController(UITableViewStyle style = UITableViewStyle.Grouped)
		{
			return new BTDialogViewController (style, BuildRootElement (useCustomHeader: style == UITableViewStyle.Plain), false);
		}

		RootElement BuildRootElement (int sections = 5, int elements = 5, bool useCustomHeader = false)
		{
			var root = new RootElement ("BigTed Themes");

			for (int s = 0; s < sections; s++)
			{
				var section = (!useCustomHeader) 
					? new BTBackgroundImageSection ("Hello", "Aenean lacinia bibendum nulla sed consectetur.")
						: new  BTBackgroundImageSection (BTBackgroundImageSection.BuildHeaderView ("Hello"));

				for (int e = 0; e < elements; e++)
				{
					section.Add (new StringElement ("Hello, World", delegate {}));
				}

				root.Add (section);
			}
			return root;
		}
	}
}
