using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xdebebe83)]
    public class TLCodeSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdebebe83;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool AllowFlashcall { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool CurrentNumber { get; set; }
        [MTParameter(Order = 3, FromFlag = 4, FlagType = FlagType.True)]
        public bool AllowAppHash { get; set; }


    }
}
