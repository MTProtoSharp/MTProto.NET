using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x3d5fb10f)]
    public class TLCreateChannel : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3d5fb10f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Broadcast { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool Megagroup { get; set; }
        [MTParameter(Order = 3)]
        public string Title { get; set; }
        [MTParameter(Order = 4)]
        public string About { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 6, FromFlag = 2, FlagType = FlagType.Null)]
        public string Address { get; set; }


    }
}
