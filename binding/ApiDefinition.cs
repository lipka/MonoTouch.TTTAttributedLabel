using System.Drawing;
using System;

using ObjCRuntime;
using Foundation;
using CoreFoundation;
using UIKit;

namespace MonoTouch.TTTAttributedLabel
{

    public delegate NSAttributedString TTTAttributedLabelSetTextDelegate(NSAttributedString s);

    [BaseType(typeof(UILabel))]
    public partial interface TTTAttributedLabel
    {
        [Field("TTTBackgroundCornerRadiusAttributeName", "__Internal")]
        NSString TTTBackgroundCornerRadius { get; set; }

        [Field("TTTBackgroundFillColorAttributeName", "__Internal")]
        NSString TTTBackgroundFillColor { get; set; }

        [Field("TTTBackgroundFillPaddingAttributeName", "__Internal")]
        NSString TTTBackgroundFillPadding { get; set; }

        [Field("TTTBackgroundLineWidthAttributeName", "__Internal")]
        NSString TTTBackgroundLineWidth { get; set; }

        [Field("TTTBackgroundStrokeColorAttributeName", "__Internal")]
        NSString TTTBackgroundStrokeColor { get; set; }

        [Field("TTTStrikeOutAttributeName", "__Internal")]
        NSString TTTStrikeOut { get; set; }


        [Export("text", ArgumentSemantic.Copy)]
        [New]
        NSObject Text { get; set; }


        [Export("delegate", ArgumentSemantic.Assign)]
        TTTAttributedLabelDelegate Delegate { get; set; }

        // Deprected
        //[Export("dataDetectorTypes")]
        //NSTextCheckingTypes DataDetectorTypes { get; set; }

        [Export("enabledTextCheckingTypes")]
        NSTextCheckingTypes EnabledTextCheckingTypes { get; set; }

        // FIXME NSTextCheckingResult
        //[Export("links", ArgumentSemantic.Strong)]
        //NSTextCheckingResult [] Links { get; }

        [Export("linkAttributes", ArgumentSemantic.Strong)]
        NSDictionary LinkAttributes { get; set; }

        [Export("activeLinkAttributes", ArgumentSemantic.Strong)]
        NSDictionary ActiveLinkAttributes { get; set; }

        [Export("inactiveLinkAttributes", ArgumentSemantic.Strong)]
        NSDictionary InactiveLinkAttributes { get; set; }

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

        // Deprected
        //[Export("leading")]
        //float Leading { get; set; }

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

        [Export("truncationTokenString", ArgumentSemantic.Strong)]
        string TruncationTokenString { get; set; }

        [Export("truncationTokenStringAttributes", ArgumentSemantic.Strong)]
        NSDictionary TruncationTokenStringAttributes { get; set; }

        [Static, Export("sizeThatFitsAttributedString:withConstraints:limitedToNumberOfLines:")]
        SizeF SizeThatFitsAttributedString(NSAttributedString attributedString, SizeF size, uint numberOfLines);

        //[Export ("text"), Verify ("ObjC method massaged into setter property", "/Users/lipka/projects/_thirdparty/TTTAttributedLabel/TTTAttributedLabel/TTTAttributedLabel.h", Line = 253)]
        //NSObject Text { set; }

        ////Export("setText:")]
        // void SetText(NSObject text);

        // [Export("setText:afterInheritingLabelAttributesAndConfiguringWithBlock:")]
        // void SetText(NSObject text, TTTAttributedLabelSetTextDelegate block);

        [Export("attributedText", ArgumentSemantic.Copy)]
        [New]
        NSAttributedString AttributedText { get; set; }

        // FIXME NSTextCheckingResult
        //[Export ("addLinkWithTextCheckingResult:")]
        //void AddLinkWithTextCheckingResult (NSTextCheckingResult result);

        // FIXME NSTextCheckingResult
        //[Export ("addLinkWithTextCheckingResult:attributes:")]
        //void AddLinkWithTextCheckingResult (NSTextCheckingResult result, NSDictionary attributes);

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

        // FIXME NSTextCheckingResult
        //[Export ("attributedLabel:didSelectLinkWithTextCheckingResult:")]
        //void DidSelectLinkWithTextCheckingResult (TTTAttributedLabel label, NSTextCheckingResult result);
    }

    /*
    [BaseType(typeof(NSObject))]
    public partial interface NSTextCheckingResult
    {

    }
    */

}
