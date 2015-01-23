using System.Drawing;
using System;

using ObjCRuntime;
using Foundation;
using CoreFoundation;
using UIKit;
using CoreGraphics;

namespace Foundation
{
    // Copied from MonoMac repository, https://github.com/mono/monomac

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor] // An uncaught exception was raised: *** -range cannot be sent to an abstract object of class NSTextCheckingResult: Create a concrete instance!
    public interface NSTextCheckingResult
    {
        [Export("resultType")]
        NSTextCheckingType ResultType { get; }

        [Export("range")]
        NSRange Range { get; }
    }
}

namespace MonoTouch.TTTAttributedLabel
{





    public delegate NSMutableAttributedString TTTAttributedLabelSetTextDelegate(NSMutableAttributedString mutableAttributedString);

    [BaseType(typeof(UILabel))]
    public partial interface TTTAttributedLabel
    {

        //kTTTStrikeOutAttributeName
        [Field("TTTStrikeOutAttributeName", "__Internal")]
        NSString StrikeOut { get; }

        //kTTTBackgroundFillColorAttributeName
        [Field("TTTBackgroundFillColorAttributeName", "__Internal")]
        NSString BackgroundFillColor { get; }

        //kTTTBackgroundFillPaddingAttributeName
        [Field("TTTBackgroundFillPaddingAttributeName", "__Internal")]
        NSString BackgroundFillPadding { get; }

        //kTTTBackgroundStrokeColorAttributeName
        [Field("TTTBackgroundStrokeColorAttributeName", "__Internal")]
        NSString BackgroundStrokeColor { get; }

        //kTTTBackgroundLineWidthAttributeName
        [Field("TTTBackgroundLineWidthAttributeName", "__Internal")]
        NSString BackgroundLineWidth { get; }

        //kTTTBackgroundCornerRadiusAttributeName
        [Field("TTTBackgroundCornerRadiusAttributeName", "__Internal")]
        NSString BackgroundCornerRadius { get; }



        //// Override UILabel @property to accept both NSString and NSAttributedString
        // @bug Setting `attributedText` directly is not recommended, as it may cause a crash when attempting to access
        // any links previously set. Instead, call `setText:`, passing an `NSAttributedString`.
      
        // Removed, if you want to set a NSAttributedString use SetText instead.

        //[Export("text", ArgumentSemantic.Copy)]
        //[New]
        //NSObject Text { get; set; }


        [Export("delegate", ArgumentSemantic.Assign)]
        TTTAttributedLabelDelegate Delegate { get; set; }

        [Obsolete]
        [Export("dataDetectorTypes")]
        NSTextCheckingTypes DataDetectorTypes { get; set; }

        [Export("enabledTextCheckingTypes")]
        NSTextCheckingTypes EnabledTextCheckingTypes { get; set; }

        // FIXME NSTextCheckingResult
        // No bindings found in Xamarin.iOS
        [Export("links", ArgumentSemantic.Strong)]       
        NSTextCheckingResult [] Links { get; }

        [Export("linkAttributes", ArgumentSemantic.Strong)]
        NSDictionary LinkAttributes { get; set; }

        [Export("activeLinkAttributes", ArgumentSemantic.Strong)]
        NSDictionary ActiveLinkAttributes { get; set; }

        [Export("inactiveLinkAttributes", ArgumentSemantic.Strong)]
        NSDictionary InactiveLinkAttributes { get; set; }

        [Export("linkBackgroundEdgeInset", ArgumentSemantic.Assign)]
        UIEdgeInsets LinkBackgroundEdgeInset { get; set; }

        [Export("shadowRadius", ArgumentSemantic.Assign)]
        float ShadowRadius { get; set; }

        [Export("highlightedShadowRadius", ArgumentSemantic.Assign)]
        float HighlightedShadowRadius { get; set; }

        [Export("highlightedShadowOffset", ArgumentSemantic.Assign)]
        SizeF HighlightedShadowOffset { get; set; }

        [Export("highlightedShadowColor", ArgumentSemantic.Retain)]
        UIColor HighlightedShadowColor { get; set; }

        [Export("kern", ArgumentSemantic.Assign)]
        float Kern { get; set; }

        [Export("firstLineIndent", ArgumentSemantic.Assign)]
        float FirstLineIndent { get; set; }

        [Obsolete]
        [Export("leading")]
        float Leading { get; set; }

        [Export("lineSpacing", ArgumentSemantic.Assign)]
        float LineSpacing { get; set; }

        [Export("minimumLineHeight", ArgumentSemantic.Assign)]
        float MinimumLineHeight { get; set; }

        [Export("maximumLineHeight", ArgumentSemantic.Assign)]
        float MaximumLineHeight { get; set; }

        [Export("lineHeightMultiple", ArgumentSemantic.Assign)]
        float LineHeightMultiple { get; set; }

        [Export("textInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextInsets { get; set; }

        [Export("verticalAlignment", ArgumentSemantic.Assign)]
        TTTAttributedLabelVerticalAlignment VerticalAlignment { get; set; }

        [Obsolete]
        [Export("truncationTokenString", ArgumentSemantic.Strong)]
        string TruncationTokenString { get; set; }

        [Obsolete]
        [Export("truncationTokenStringAttributes", ArgumentSemantic.Strong)]
        NSDictionary TruncationTokenStringAttributes { get; set; }

        [Export("attributedTruncationToken", ArgumentSemantic.Strong)]
        NSAttributedString AttributedTruncationToken { get; set; }

        [Static, Export("sizeThatFitsAttributedString:withConstraints:limitedToNumberOfLines:")]
        SizeF SizeThatFitsAttributedString(NSAttributedString attributedString, SizeF size, uint numberOfLines);

        // @bug Setting `attributedText` directly is not recommended, as it may cause a crash when attempting to access
        // any links previously set. Instead, call `setText:`, passing an `NSAttributedString`.
        [Export("setText:")]
        void SetText(NSObject text);

        [Export("setText:afterInheritingLabelAttributesAndConfiguringWithBlock:")]
        void SetText(NSObject text, TTTAttributedLabelSetTextDelegate block);

        [Export("attributedText", ArgumentSemantic.Copy)]
        [New]
        NSAttributedString AttributedText { get; set; }

        [Export("addLinkWithTextCheckingResult:")]
        void AddLinkWithTextCheckingResult(NSTextCheckingResult result);

        [Export("addLinkWithTextCheckingResult:attributes:")]
        void AddLinkWithTextCheckingResult(NSTextCheckingResult result, NSDictionary attributes);

        [Export("addLinkToURL:withRange:")]
        void AddLinkToURL(NSUrl url, NSRange range);

        [Export("addLinkToAddress:withRange:")]
        void AddLinkToAddress(NSDictionary addressComponents, NSRange range);

        [Export("addLinkToPhoneNumber:withRange:")]
        void AddLinkToPhoneNumber(string phoneNumber, NSRange range);

        [Export("addLinkToDate:withRange:")]
        void AddLinkToDate(NSDate date, NSRange range);

        [Export("addLinkToDate:timeZone:duration:withRange:")]
        void AddLinkToDate(NSDate date, NSTimeZone timeZone, double duration, NSRange range);

        [Export("addLinkToTransitInformation:withRange:")]
        void AddLinkToTransitInformation(NSDictionary components, NSRange range);

        [Export("containslinkAtPoint:")]
        bool ContainslinkAtPoint(CGPoint point);

    }

    [BaseType(typeof(NSObject))]
    [Model][Protocol]
    public partial interface TTTAttributedLabelDelegate
    {

        [Export("attributedLabel:didSelectLinkWithURL:")]
        void DidSelectLinkWithURL(TTTAttributedLabel label, NSUrl url);

        [Export("attributedLabel:didSelectLinkWithAddress:")]
        void DidSelectLinkWithAddress(TTTAttributedLabel label, NSDictionary addressComponents);

        [Export("attributedLabel:didSelectLinkWithPhoneNumber:")]
        void DidSelectLinkWithPhoneNumber(TTTAttributedLabel label, string phoneNumber);

        [Export("attributedLabel:didSelectLinkWithDate:")]
        void DidSelectLinkWithDate(TTTAttributedLabel label, NSDate date);

        [Export("attributedLabel:didSelectLinkWithDate:timeZone:duration:")]
        void DidSelectLinkWithDate(TTTAttributedLabel label, NSDate date, NSTimeZone timeZone, double duration);

        [Export("attributedLabel:didSelectLinkWithTransitInformation:")]
        void DidSelectLinkWithTransitInformation(TTTAttributedLabel label, NSDictionary components);

        [Export("attributedLabel:didSelectLinkWithTextCheckingResult:")]
        void DidSelectLinkWithTextCheckingResult(TTTAttributedLabel label, NSTextCheckingResult result);
    }
}
