using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Channels
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Broadcast { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Megagroup { get; set; }
        [MTParameter(Order = 3)]
        public string Title { get; set; }
        [MTParameter(Order = 4)]
        public string About { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsInputGeoPoint GeoPoint { get; set; }
        [MTParameter(Order = 6, FlagBitId = 2, FlagType = FlagType.Null)]
        public string Address { get; set; }


    }
}
