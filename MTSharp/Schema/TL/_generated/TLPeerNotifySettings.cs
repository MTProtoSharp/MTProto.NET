using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xaf509d20)]
    public class TLPeerNotifySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaf509d20;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public bool? ShowPreviews { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public bool? Silent { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public int? MuteUntil { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.Null)]
        public string Sound { get; set; }


    }
}
