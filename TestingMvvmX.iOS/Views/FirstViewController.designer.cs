// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TestingMvvmX.iOS
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lbl { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txt { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txt != null) {
				txt.Dispose ();
				txt = null;
			}

			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}

			if (btn != null) {
				btn.Dispose ();
				btn = null;
			}
		}
	}
}
