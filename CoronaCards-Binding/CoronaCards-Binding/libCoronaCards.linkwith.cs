using System;
using MonoTouch.ObjCRuntime;

[assembly:LinkWith ("libCoronaCards.a",
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, 
	IsCxx = true,
	Frameworks = "UIKit SystemConfiguration Security QuartzCore OpenAL OpenGLES MobileCoreServices MediaPlayer ImageIO GLKit CoreVideo CoreGraphics CoreLocation CoreMedia CoreMotion CFNetWork AVFoundation AudioToolbox AdSupport Foundation",
	LinkerFlags = "-lstdc++ -lz -lsqlite3 -ObjC -lobjc",
	ForceLoad = true)]