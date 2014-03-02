// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TTTTest
{
	[Register ("TTTTestViewController")]
	partial class TTTTestViewController
	{
		[Outlet]
		MonoTouch.TTTAttributedLabel.TTTAttributedLabel label { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (label != null) {
				label.Dispose ();
				label = null;
			}
		}
	}
}
