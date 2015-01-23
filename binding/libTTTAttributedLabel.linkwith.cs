using System;
using ObjCRuntime;

[assembly: LinkWith("libTTTAttributedLabel.a",
    LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64,
    Frameworks = "CoreText CoreGraphics QuartzCore",
    ForceLoad = true,
    LinkerFlags = "-Xlinker -alias -Xlinker _kTTTStrikeOutAttributeName -Xlinker _TTTStrikeOutAttributeName -Xlinker -alias -Xlinker _kTTTBackgroundFillColorAttributeName -Xlinker _TTTBackgroundFillColorAttributeName -Xlinker -alias -Xlinker _kTTTBackgroundFillPaddingAttributeName -Xlinker _TTTBackgroundFillPaddingAttributeName -Xlinker -alias -Xlinker _kTTTBackgroundStrokeColorAttributeName -Xlinker _TTTBackgroundStrokeColorAttributeName -Xlinker -alias -Xlinker _kTTTBackgroundLineWidthAttributeName -Xlinker _TTTBackgroundLineWidthAttributeName -Xlinker -alias -Xlinker _kTTTBackgroundCornerRadiusAttributeName -Xlinker _TTTBackgroundCornerRadiusAttributeName")]