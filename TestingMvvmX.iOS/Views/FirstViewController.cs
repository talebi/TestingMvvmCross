using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using System.Collections.Generic;
using TestingMvvmX.Core;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace TestingMvvmX.iOS
{
	public partial class FirstViewController : MvxViewController
	{
		public FirstViewController () : base ("FirstViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var bindSet = this.CreateBindingSet<FirstViewController, FirstViewModel> ();

			bindSet.Bind (lbl).To (vm => vm.Name);
			bindSet.Bind (txt).To (vm => vm.Name);
			this.AddBindings(new Dictionary<object, string>()
				{
					{ btn, "TouchUpInside ShowSecondVM" },                                                              
				});
			//btn.TouchUpInside += HandleTouchInside;
			//bindSet.Bind (btn).To (vm => vm.SetNameToHi.Execute());

			bindSet.Apply ();
		}
	}
}

