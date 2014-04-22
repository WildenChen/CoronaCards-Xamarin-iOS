using System;
using MonoTouch.ObjCRuntime;

[assembly:LinkWith ("libCoronaCards.a",
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, 
	IsCxx = true,
	Frameworks = "UIKit SystemConfiguration Security QuartzCore OpenAL OpenGLES MobileCoreServices MediaPlayer ImageIO GLKit CoreVideo CoreGraphics CoreLocation CoreMedia CoreMotion CFNetWork AVFoundation AudioToolbox AdSupport Foundation",
	LinkerFlags = "-lstdc++ -lz -lsqlite3",
	ForceLoad = true)]

//LinkerFlags = "-lz -lc++ -lstdc++ -all_load -ObjC",
//[LinkWith (..., Frameworks="Foundation", WeakFrameworks="AdSupport, Social, Accounts")]
//	//Frameworks = "CoreGraphics CoreLocation CoreText Foundation QuartzCore MediaPlayer MobileCoreServices OpenGLES Security UIKit",

//using MonoTouch.UIKit;
//using System.Configuration;
//using System.Security;
//QuartzCore
//OpenAL
//using MonoTouch.OpenGLES;
//using MonoTouch.MobileCoreServices;
//using MonoTouch.MediaPlayer;
//using MonoTouch.ImageIO;
//using MonoTouch.GLKit;
//using MonoTouch.CoreVideo;
//using MonoTouch.CoreGraphics;
//using MonoTouch.CoreLocation;
//using MonoTouch.CoreMedia;
//using MonoTouch.CoreMotion;
////CFNetWork
//using MonoTouch.AVFoundation;
//using MonoTouch.AudioToolbox;
//using MonoTouch.AdSupport;
//using MonoTouch.Foundation;
//XCTest


