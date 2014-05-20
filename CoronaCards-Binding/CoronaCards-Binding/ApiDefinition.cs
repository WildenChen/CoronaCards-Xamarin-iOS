using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.GLKit;

namespace CoronaCards
{
	[BaseType (typeof (GLKViewController))]
	public partial interface CoronaViewController {

	}


	[BaseType (typeof (GLKView))]
	public partial interface CoronaView {

		[Export ("coronaViewDelegate", ArgumentSemantic.Assign)]
		CoronaViewDelegate CoronaViewDelegate { get; set; }

		[Export ("run")]
		int Run (); //int Run { get; }

		[Export ("runWithPath:parameters:")]
		int RunWithPath (string pPath, NSDictionary pParams);

		[Export ("suspend")]
		void Suspend ();

		[Export ("resume")]
		void Resume ();

		[Export ("sendEvent:")]
		NSObject SendEvent (NSDictionary pEvent);
	}

	[BaseType (typeof (NSObject))]
	[Model][Protocol]
	public partial interface CoronaViewDelegate {

		[Export ("coronaView:receiveEvent:")]
		NSObject ReceiveEvent(CoronaView pView, NSDictionary pEvent);

		[Export ("coronaViewWillSuspend:")]
		void CoronaViewWillSuspend(CoronaView pView);

		[Export ("coronaViewDidSuspend:")]
		void CoronaViewDidSuspend(CoronaView pView);

		[Export ("coronaViewWillResume:")]
		void CoronaViewWillResume(CoronaView pView);

		[Export ("coronaViewDidResume:")]
		void CoronaViewDidResume(CoronaView pView);
	}
}

