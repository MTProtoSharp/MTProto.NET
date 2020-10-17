using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Updates
{
    [MTObject(0x25939651)]
    public class TLGetDifference : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x25939651;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int Pts { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? PtsTotalLimit { get; set; }
        [MTParameter(Order = 3)]
        public int Date { get; set; }
        [MTParameter(Order = 4)]
        public int Qts { get; set; }


    }
}
