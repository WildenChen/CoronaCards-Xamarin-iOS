using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CoronaCards;

namespace CoronaCardsSample
{
	public class MainViewController: UIViewController
	{

		public MainViewController ():base()
		{
			CoronaViewController _coronaViewController = new CoronaViewController ();
			this.AddChildViewController (_coronaViewController);

			CoronaView _view = _coronaViewController.View as CoronaView;
			_view.Frame = this.View.Frame;
			this.View.AddSubview (_view);
			_view.Run ();

		}
	}

}

