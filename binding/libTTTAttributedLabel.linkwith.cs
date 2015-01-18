using System;
using ObjCRuntime;

[assembly: LinkWith("libTTTAttributedLabel.a",
    LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64,
    Frameworks = "CoreGraphics CoreText QuartzCore",
    ForceLoad = true, 
    LinkerFlags = "-Xlinker -alias -Xlinker _kTTTBackgroundCornerRadiusAttributeName -Xlinker _TTTBackgroundCornerRadiusAttributeName " +
    "-Xlinker -alias -Xlinker _kTTTBackgroundFillColorAttributeName -Xlinker _TTTBackgroundFillColorAttributeName " +
    "-Xlinker -alias -Xlinker _kTTTBackgroundFillPaddingAttributeName -Xlinker _TTTBackgroundFillPaddingAttributeName " +
    "-Xlinker -alias -Xlinker _kTTTBackgroundLineWidthAttributeName -Xlinker _TTTBackgroundLineWidthAttributeName " +
    "-Xlinker -alias -Xlinker _kTTTBackgroundStrokeColorAttributeName -Xlinker _TTTBackgroundStrokeColorAttributeName " +
    "-Xlinker -alias -Xlinker _kTTTStrikeOutAttributeName -Xlinker _TTTStrikeOutAttributeName ")]