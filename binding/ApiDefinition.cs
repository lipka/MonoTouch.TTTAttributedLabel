using System.Drawing;
using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;

namespace MonoTouch.TTTAttributedLabel {

	public delegate NSAttributedString TTTAttributedLabelSetTextDelegate (NSAttributedString s);

	[BaseType (typeof (UILabel))]
	public partial interface TTTAttributedLabel {

		[Export ("delegate", ArgumentSemantic.Assign)]
		TTTAttributedLabelDelegate Delegate { get; set; }

		[Export ("dataDetectorTypes")]
		NSTextCheckingTypes DataDetectorTypes { get; set; }

		[Export ("enabledTextCheckingTypes")]
		NSTextCheckingTypes EnabledTextCheckingTypes { get; set; }

		// FIXME NSTextCheckingResult
		//[Export ("links", ArgumentSemantic.Retain), Verify ("NSArray may be reliably typed, check the documentation", "/Users/lipka/projects/_thirdparty/TTTAttributedLabel/TTTAttributedLabel/TTTAttributedLabel.h", Line = 123)]
		//NSObject [] Links { get; }

		[Export ("linkAttributes", ArgumentSemantic.Retain)]
		NSDictionary LinkAttributes { get; set; }

		[Export ("activeLinkAttributes", ArgumentSemantic.Retain)]
		NSDictionary ActiveLinkAttributes { get; set; }

		[Export ("inactiveLinkAttributes", ArgumentSemantic.Retain)]
		NSDictionary InactiveLinkAttributes { get; set; }

		[Export ("shadowRadius")]
		float ShadowRadius { get; set; }

		[Export ("highlightedShadowRadius")]
		float HighlightedShadowRadius { get; set; }

		[Export ("highlightedShadowOffset", ArgumentSemantic.Assign)]
		SizeF HighlightedShadowOffset { get; set; }

		[Export ("highlightedShadowColor", ArgumentSemantic.Retain)]
		UIColor HighlightedShadowColor { get; set; }

		[Export ("kern")]
		float Kern { get; set; }

		[Export ("firstLineIndent")]
		float FirstLineIndent { get; set; }

		[Export ("leading")]
		float Leading { get; set; }

		[Export ("lineHeightMultiple")]
		float LineHeightMultiple { get; set; }

		[Export ("textInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets TextInsets { get; set; }

		[Export ("verticalAlignment")]
		TTTAttributedLabelVerticalAlignment VerticalAlignment { get; set; }

		[Export ("truncationTokenString", ArgumentSemantic.Retain)]
		string TruncationTokenString { get; set; }

		[Export ("truncationTokenStringAttributes", ArgumentSemantic.Retain)]
		NSDictionary TruncationTokenStringAttributes { get; set; }

		[Static, Export ("sizeThatFitsAttributedString:withConstraints:limitedToNumberOfLines:")]
		SizeF SizeThatFitsAttributedString (NSAttributedString attributedString, SizeF size, uint numberOfLines);

		//[Export ("text"), Verify ("ObjC method massaged into setter property", "/Users/lipka/projects/_thirdparty/TTTAttributedLabel/TTTAttributedLabel/TTTAttributedLabel.h", Line = 253)]
		//NSObject Text { set; }

		[Export ("setText:afterInheritingLabelAttributesAndConfiguringWithBlock:")]
		void SetText (NSObject text, TTTAttributedLabelSetTextDelegate block);

		[Export ("attributedText", ArgumentSemantic.Copy)]
		NSAttributedString AttributedText { get; set; }

		// FIXME NSTextCheckingResult
		//[Export ("addLinkWithTextCheckingResult:")]
		//void AddLinkWithTextCheckingResult (NSTextCheckingResult result);

		// FIXME NSTextCheckingResult
		//[Export ("addLinkWithTextCheckingResult:attributes:")]
		//void AddLinkWithTextCheckingResult (NSTextCheckingResult result, NSDictionary attributes);

		[Export ("addLinkToURL:withRange:")]
		void AddLinkToURL (NSUrl url, NSRange range);

		[Export ("addLinkToAddress:withRange:")]
		void AddLinkToAddress (NSDictionary addressComponents, NSRange range);

		[Export ("addLinkToPhoneNumber:withRange:")]
		void AddLinkToPhoneNumber (string phoneNumber, NSRange range);

		[Export ("addLinkToDate:withRange:")]
		void AddLinkToDate (NSDate date, NSRange range);

		[Export ("addLinkToDate:timeZone:duration:withRange:")]
		void AddLinkToDate (NSDate date, NSTimeZone timeZone, double duration, NSRange range);

		[Export ("addLinkToTransitInformation:withRange:")]
		void AddLinkToTransitInformation (NSDictionary components, NSRange range);
	}

	public partial interface TTTAttributedLabel {

		[Export ("text", ArgumentSemantic.Copy)]
		NSObject Text { get; set; }
	}

	[BaseType (typeof (NSObject))]
	[Model][Protocol]
	public partial interface TTTAttributedLabelDelegate {

		[Export ("attributedLabel:didSelectLinkWithURL:")]
		void DidSelectLinkWithURL (TTTAttributedLabel label, NSUrl url);

		[Export ("attributedLabel:didSelectLinkWithAddress:")]
		void DidSelectLinkWithAddress (TTTAttributedLabel label, NSDictionary addressComponents);

		[Export ("attributedLabel:didSelectLinkWithPhoneNumber:")]
		void DidSelectLinkWithPhoneNumber (TTTAttributedLabel label, string phoneNumber);

		[Export ("attributedLabel:didSelectLinkWithDate:")]
		void DidSelectLinkWithDate (TTTAttributedLabel label, NSDate date);

		[Export ("attributedLabel:didSelectLinkWithDate:timeZone:duration:")]
		void DidSelectLinkWithDate (TTTAttributedLabel label, NSDate date, NSTimeZone timeZone, double duration);

		[Export ("attributedLabel:didSelectLinkWithTransitInformation:")]
		void DidSelectLinkWithTransitInformation (TTTAttributedLabel label, NSDictionary components);

		// FIXME NSTextCheckingResult
		//[Export ("attributedLabel:didSelectLinkWithTextCheckingResult:")]
		//void DidSelectLinkWithTextCheckingResult (TTTAttributedLabel label, NSTextCheckingResult result);
	}
}
