using System;

namespace MonoTouch.TTTAttributedLabel
{
	// FIXME
	public enum NSTextCheckingTypes : ulong {
		NSTextCheckingTypeOrthography           = 1ULL << 0,            // language identification
		NSTextCheckingTypeSpelling              = 1ULL << 1,            // spell checking
		NSTextCheckingTypeGrammar               = 1ULL << 2,            // grammar checking
		NSTextCheckingTypeDate                  = 1ULL << 3,            // date/time detection
		NSTextCheckingTypeAddress               = 1ULL << 4,            // address detection
		NSTextCheckingTypeLink                  = 1ULL << 5,            // link detection
		NSTextCheckingTypeQuote                 = 1ULL << 6,            // smart quotes
		NSTextCheckingTypeDash                  = 1ULL << 7,            // smart dashes
		NSTextCheckingTypeReplacement           = 1ULL << 8,            // fixed replacements, such as copyright symbol for (c)
		NSTextCheckingTypeCorrection            = 1ULL << 9,            // autocorrection
		NSTextCheckingTypeRegularExpression /*		NS_ENUM_AVAILABLE(10_7, 4_0)*/  = 1ULL << 10,           // regular expression matches
		NSTextCheckingTypePhoneNumber /*		NS_ENUM_AVAILABLE(10_7, 4_0)*/        = 1ULL << 11,           // phone number detection
		NSTextCheckingTypeTransitInformation /*		NS_ENUM_AVAILABLE(10_7, 4_0)*/ = 1ULL << 12            // transit (e.g. flight) info detection
	}

	public enum TTTAttributedLabelVerticalAlignment {
		Center = 0,
		Top = 1,
		Bottom = 2
	}
}

