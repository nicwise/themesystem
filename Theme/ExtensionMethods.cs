using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.Dialog;

namespace BigTed.Theme
{
	public static class ExtensionMethods
	{
		public static UIColor ToUIColor(this string hexString)
		{
			if (hexString.Contains("#")) hexString = hexString.Replace("#", "");

			if (hexString.Length != 6) return UIColor.Red;

			int red = Int32.Parse(hexString.Substring(0,2), System.Globalization.NumberStyles.AllowHexSpecifier);
			int green = Int32.Parse(hexString.Substring(2,2), System.Globalization.NumberStyles.AllowHexSpecifier);
			int blue = Int32.Parse(hexString.Substring(4,2), System.Globalization.NumberStyles.AllowHexSpecifier);

			return UIColor.FromRGB(red, green, blue);
		}

		public static SizeF StringSize(this UILabel label)
		{
			return new NSString(label.Text).StringSize(label.Font);
		}

		public static void SizeAllSections(this RootElement root)
		{
			SizeF max = new SizeF (0,0);
			var font = UIFont.BoldSystemFontOfSize (17);

			foreach(var section in root)
			{
				foreach(var ee in section)
				{
					var e = ee as EntryElement;
					if (e == null) continue;

					if (e.Caption != null) 
					{
						var size = new NSString(e.Caption).StringSize (font);
						if (size.Width > max.Width)
							max = size;
					}
				}
			}

			var newSize = new SizeF (25 + Math.Min (max.Width, 160), max.Height);

			foreach(var section in root)
			{
				section.EntryAlignment = newSize;
			}


		}


		public static void EachElement(this RootElement element, Action<EntryElement> eachAction)
		{
			foreach(var section in element)
			{
				foreach(var ee in section.Elements)
				{
					var e = ee as EntryElement;
					if (e == null) continue;

					eachAction(e);
				}
			}
		}
	}
}

