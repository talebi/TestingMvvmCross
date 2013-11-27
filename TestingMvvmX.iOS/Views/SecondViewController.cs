using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using TestingMvvmX.Core;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace TestingMvvmX.iOS
{
	public partial class SecondViewController : MvxViewController
	{
		public SecondViewController () : base ("SecondViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			var bindSet = this.CreateBindingSet<SecondViewController, SecondViewModel> ();

			bindSet.Bind (lbl).To (vm => vm.Name2);
			bindSet.Bind (txt).To (vm => vm.Name2);
			//btn.TouchUpInside += HandleTouchInside;
			//bindSet.Bind (btn).To (vm => vm.SetNameToHi.Execute());

			bindSet.Apply ();
		}
	}
}

