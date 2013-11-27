using System;
using Cirrious.MvvmCross.ViewModels;

namespace TestingMvvmX.Core
{
	public class SecondViewModel : MvxViewModel
	{
		public SecondViewModel ()
		{
			Name2 = "2nd viewcontroller";
		}

		string name2;
		public string Name2 {
			get {
				return name2;
			}
			set {
				name2 = value;
				RaisePropertyChanged (() => Name2);
			}
		}
	}
}

