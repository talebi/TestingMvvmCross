using System;
using Cirrious.MvvmCross.ViewModels;

namespace TestingMvvmX.Core
{
	public class FirstViewModel : MvxViewModel
	{
		public FirstViewModel ()
		{
			Name = "1st viewcontroller";
		}

		string _name;
		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
				RaisePropertyChanged (() => Name);
			}
		}


		public IMvxCommand SetNameToHi {
			get { return new MvxCommand(()=> Name = "hello") ; }
		}

		public IMvxCommand ShowSecondVM {
			get { return new MvxCommand (() => ShowViewModel<SecondViewModel> ()); }
		}


		public void SetName()
		{
			Name = "hibib hoora!!!";
		}
	}
}

