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
		int RunWithPath (string path, NSDictionary pParams);

		[Export ("suspend")]
		void Suspend ();

		[Export ("resume")]
		void Resume ();

		[Export ("sendEvent:")]
		NSObject SendEvent (NSDictionary pEvent);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface CoronaViewDelegate {

		[Export ("coronaView:receiveEvent:")]
		NSObject ReceiveEvent(CoronaView view, NSDictionary pEvent);

		[Export ("coronaViewWillSuspend:")]
		void CoronaViewWillSuspend(CoronaView view);

		[Export ("coronaViewDidSuspend:")]
		void CoronaViewDidSuspend(CoronaView view);

		[Export ("coronaViewWillResume:")]
		void CoronaViewWillResume(CoronaView view);

		[Export ("coronaViewDidResume:")]
		void CoronaViewDidResume(CoronaView view);
	}
}

