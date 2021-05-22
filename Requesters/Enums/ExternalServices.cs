using System;

namespace Requesters.Enums
{
    [Flags]
    public enum ExternalServices
    {
        Amadeus = 1 << 0,
        Yaya = 1 << 1,
        Shlomo = 1 << 2
    }
}