using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Extensions;
using CoronaCards;

namespace CoronaCardsCommunication
{
	public class MainViewController:UIViewController
	{
		CoronaViewController mCoronaCardsViewController;
		public MainViewController () : base ()
		{
			mCoronaCardsViewController = new CoronaViewController ();
			this.AddChildViewController (mCoronaCardsViewController);

			mCoronaCardsViewController.View.Frame = this.View.Frame;
			this.View.AddSubview (mCoronaCardsViewController.View);

			CoronaView _view = mCoronaCardsViewController.View as CoronaView;
			_view.CoronaCards ().OnReceive += HandleOnReceive;
			_view.Run ();

			var keys = new object[] {"name", "phase","otherKey" };
			var objects = new object[] { "pauseEvent","pause","otherValue" };
			NSDictionary _event = NSDictionary.FromObjectsAndKeys(objects, keys);

			_view.SendEvent (_event);
			//mCoronaCardsViewController.CoronaCardsView.OnReceive+= HandleOnReceive;;
		}

		void HandleOnReceive (CoronaView target, NSDictionary e)
		{
			Console.WriteLine ("HandleOnReceive:{0}",e);
		}

	}
}

