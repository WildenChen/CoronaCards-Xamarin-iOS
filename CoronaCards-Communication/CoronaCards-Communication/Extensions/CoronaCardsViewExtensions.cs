using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CoronaCards;

namespace Extensions
{
	public enum CoronaEventType{
		WillSuspend,
		DidSuspend,
		WillResume,
		DidResume
	}

	public delegate void CoronaCardsEventHandler (CoronaView target, NSDictionary e);
	public delegate void CoronaEventHandler (CoronaView target, CoronaEventType e);

	public static class CoronaCardsExtensions{
		//public static SwipeClass Swipe(this UIView view, UISwipeGestureRecognizerDirection direction)
		public static CoronaCardsViewClass CoronaCards(this CoronaView pCoronaView){
			CoronaCardsViewClass _coronaCards = new CoronaCardsViewClass(pCoronaView);
			return _coronaCards;
		}
	}







	public class CoronaCardsViewClass
	{
		public event CoronaCardsEventHandler OnReceive;
		public event CoronaEventHandler OnWillSuspend;
		public event CoronaEventHandler OnDidSuspend;
		public event CoronaEventHandler OnWillResume;
		public event CoronaEventHandler OnDidResume;

		CoronaCardsDelegate mCoronaCardsDelegate;
		public readonly CoronaView CoronaView;

		internal CoronaCardsViewClass (CoronaView pCoronaView)
		{
			CoronaView = pCoronaView;
			mCoronaCardsDelegate = new CoronaCardsDelegate ();
			pCoronaView.CoronaViewDelegate = mCoronaCardsDelegate;
			mCoronaCardsDelegate.OnReceive += HandleOnReceive;
			mCoronaCardsDelegate.OnWillSuspend += HandleOnWillSuspend;;
			mCoronaCardsDelegate.OnDidSuspend += HandleOnDidSuspend;
			mCoronaCardsDelegate.OnWillResume += HandleOnWillResume;
			mCoronaCardsDelegate.OnDidResume += HandleOnDidResume;
		}



		protected virtual void HandleOnReceive (CoronaView target, NSDictionary e)
		{
			if(OnReceive!=null){
				OnReceive (target,e);
			}
		}

		protected virtual void HandleOnWillSuspend (CoronaView target, CoronaEventType e)
		{
			if(OnWillSuspend!=null){
				OnWillSuspend (target, e);
			}
		}

		protected virtual void HandleOnDidSuspend (CoronaView target, CoronaEventType e)
		{
			if(OnDidSuspend!=null){
				OnDidSuspend (target, e);
			}
		}
		protected virtual void HandleOnWillResume (CoronaView target, CoronaEventType e)
		{
			if(OnWillResume!=null){
				OnWillResume (target, e);
			}
		}

		protected virtual void HandleOnDidResume (CoronaView target, CoronaEventType e)
		{
			if(OnDidResume!=null){
				OnDidResume (target, e);
			}
		}

		class CoronaCardsDelegate:CoronaViewDelegate{
			public event CoronaCardsEventHandler OnReceive;
			public event CoronaEventHandler OnWillSuspend;
			public event CoronaEventHandler OnDidSuspend;
			public event CoronaEventHandler OnWillResume;
			public event CoronaEventHandler OnDidResume;

			public override NSObject ReceiveEvent (CoronaView view, NSDictionary pEvent)
			{
				if(OnReceive!=null){
					OnReceive (view,pEvent);
				}

				//Console.WriteLine ("CoronaViewDelegate.ReceiveEvent:{0}",pEvent);
				return new NSString( pEvent.ToString());
			}

			public override void CoronaViewWillSuspend (CoronaView view)
			{
				if(OnWillSuspend!=null){
					OnWillSuspend (view, CoronaEventType.WillResume);
				}
			}

			public override void CoronaViewDidSuspend (CoronaView view)
			{
				if(OnDidSuspend!=null){
					OnDidSuspend (view, CoronaEventType.DidSuspend);
				}
			}

			public override void CoronaViewWillResume (CoronaView view)
			{
				if(OnWillResume!=null){
					OnWillResume (view, CoronaEventType.WillResume);
				}
			}

			public override void CoronaViewDidResume (CoronaView view)
			{
				if(OnDidResume!=null){
					OnDidResume (view, CoronaEventType.DidResume);
				}
			}
		}
	}
}

