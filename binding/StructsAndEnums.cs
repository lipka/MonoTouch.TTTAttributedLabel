using System;

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

