using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.TTTAttributedLabel;

namespace TTTTest
{
  public partial class TTTTestViewController : UIViewController
  {
    static bool UserInterfaceIdiomIsPhone
    {
      get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
    }

    public TTTTestViewController()
			: base(UserInterfaceIdiomIsPhone ? "TTTTestViewController_iPhone" : "TTTTestViewController_iPad", null)
    {
    }

    public override void DidReceiveMemoryWarning()
    {
      // Releases the view if it doesn't have a superview.
      base.DidReceiveMemoryWarning();
			
      // Release any cached data, images, etc that aren't in use.
    }

    public override void ViewDidLoad()
    {
      base.ViewDidLoad();
      //
      // TTTAttributedLabel label = new TTTAttributedLabel ();
      label.Text = new NSString ("I love Tink");
      label.AddLinkToURL (new NSUrl ("http://tinkapp.com/"), new NSRange (7, 4));
      label.Delegate = new LabelDelegate();
      label.BackgroundColor = UIColor.Cyan;

      View.AddSubview(label);

      // Perform any additional setup after loading the view, typically from a nib.
    }
  }

  class LabelDelegate : TTTAttributedLabelDelegate 
  {
    public override void DidSelectLinkWithURL (TTTAttributedLabel label, NSUrl url)
    {
      Console.WriteLine ("Clicked URL: {0}", url.ToString ());
    }
  }
}

