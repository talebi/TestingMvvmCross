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
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lbl { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txt { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}

			if (txt != null) {
				txt.Dispose ();
				txt = null;
			}
		}
	}
}
