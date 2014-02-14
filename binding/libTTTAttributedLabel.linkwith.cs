using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTTTAttributedLabel.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
