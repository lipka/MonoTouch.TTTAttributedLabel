using System;
using ObjCRuntime;

[assembly: LinkWith ("libTTTAttributedLabel.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks = "CoreGraphics CoreText QuartzCore", ForceLoad = true)]
