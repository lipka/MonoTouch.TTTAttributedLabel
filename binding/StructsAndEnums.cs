using System;

/*
namespace Foundation
{
    // Copied from MonoMac repository, https://github.com/mono/monomac
    public enum NSTextCheckingType : ulong
    {
        Orthography = 1 << 0,
        Spelling = 1 << 1,
        Grammar = 1 << 2,
        Date = 1 << 3,
        Address = 1 << 4,
        Link = 1 << 5,
        Quote = 1 << 6,
        Dash = 1 << 7,
        Replacement = 1 << 8,
        Correction = 1 << 9
    }
}
*/

namespace MonoTouch.TTTAttributedLabel
{
    public enum NSTextCheckingTypes : ulong
    {
        NSTextCheckingAllSystemTypes = 0xffffffffULL,
        NSTextCheckingAllCustomTypes = 0xffffffffULL << 32,
        NSTextCheckingAllTypes = (0xffffffffULL | 0xffffffffULL << 32)
    }

    public enum TTTAttributedLabelVerticalAlignment
    {
        Center = 0,
        Top = 1,
        Bottom = 2
    }
}

