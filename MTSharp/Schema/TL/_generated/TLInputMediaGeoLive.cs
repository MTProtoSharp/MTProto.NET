using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xce4e82fd)]
    public class TLInputMediaGeoLive : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xce4e82fd;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Stopped { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public int? Period { get; set; }


    }
}
