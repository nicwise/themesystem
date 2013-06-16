using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using System.Threading.Tasks;
using System.Drawing;

namespace BigTed.Theme
{
	public class BTBackgroundImageSection : Section, IBackgroundImageSection
	{

		public BTBackgroundImageSection (string header) : base(header)
		{
			//HeaderView = BuildHeaderView (header);
		}

		public BTBackgroundImageSection (string header, string footer) : base(header, footer)
		{
			//HeaderView = BuildHeaderView (header);
			//FooterView = BuildHeaderView (footer);
		}

		public BTBackgroundImageSection () : base("", "")
		{

		}

		public BTBackgroundImageSection (UIView header) : base(header)
		{

		}

		public BTBackgroundImageSection (UIView header, UIView footer) : base(header, footer)
		{
		}


		public UITableViewCell CustomizeCell (UITableViewCell cell, MonoTouch.Foundation.NSIndexPath indexPath, UITableViewStyle style)
		{
			if (style == UITableViewStyle.Grouped)
			{

				if (Count == 1)
				{
					cell.BackgroundView = new UIImageView (Resources.CellBackgroundFull);
					cell.SelectedBackgroundView = new UIImageView (Resources.CellBackgroundFullSelected);

				} else if (indexPath.Row == 0)
				{
					cell.BackgroundView = new UIImageView (Resources.CellBackgroundTop);
					cell.SelectedBackgroundView = new UIImageView (Resources.CellBackgroundTopSelected);

				} else if (indexPath.Row + 1 == this.Count)
				{
					cell.BackgroundView = new UIImageView (Resources.CellBackgroundBottom);
					cell.SelectedBackgroundView = new UIImageView (Resources.CellBackgroundBottomSelected);
				} else
				{
					cell.BackgroundView = new UIImageView (Resources.CellBackgroundMiddle);
					cell.SelectedBackgroundView = new UIImageView (Resources.CellBackgroundMiddleSelected);
				}

				cell.TextLabel.BackgroundColor = UIColor.Clear;
				if (cell.DetailTextLabel != null) cell.DetailTextLabel.BackgroundColor = UIColor.Clear;

			} else {
				cell.BackgroundView = new UIImageView (Resources.CellBackgroundPlain);
				cell.SelectedBackgroundView = new UIImageView (Resources.CellBackgroundPlainSelected);
			}

			return cell;

		}

		public static UIView BuildEmptySection()
		{
			UIFont font = UIFont.SystemFontOfSize(15f);
			SizeF maxSize = new SizeF(280, 999);


			var view = new UIView(new RectangleF(0,0,280, 2)) {
				BackgroundColor = UIColor.Clear
			};


			return view;
		}

		public static UIView BuildHeaderView(string caption)
		{
		
			UIView view = new UIView(new RectangleF(0,0,320,23));

			UIImageView background = new UIImageView(Resources.SectionHeaderBackground);
			background.Frame = view.Frame;


			UILabel label = new UILabel();
			label.BackgroundColor = UIColor.Clear;
			label.Opaque = false;
			label.TextColor = UIColor.FromRGB(119,119,119);
			//label.HighlightedTextColor = UIColor.White;
			label.Font = UIFont.BoldSystemFontOfSize(13.5f); //UIFont.FromName("Helvetica Neue Bold", 13.5f);
			label.Frame = new RectangleF(8,0,200,23);
			label.Text = caption;
			//var layer = label.Layer;
			label.ShadowColor = UIColor.FromRGBA(255,255,255,128);
			//layer.ShadowRadius = 5f; 
			label.ShadowOffset = new SizeF(0, 1);
			//layer.ShadowOpacity = 1.0f;


			view.AddSubview(background);
			view.AddSubview(label);

			return view;


		}


	}
}

