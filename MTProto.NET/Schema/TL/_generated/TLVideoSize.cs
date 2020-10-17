using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe831c556)]
    public class TLVideoSize : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe831c556;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Type { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLFileLocationToBeDeprecated Location { get; set; }
        [MTParameter(Order = 3)]
        public int W { get; set; }
        [MTParameter(Order = 4)]
        public int H { get; set; }
        [MTParameter(Order = 5)]
        public int Size { get; set; }
        [MTParameter(Order = 6, FlagBitId = 0, FlagType = FlagType.Null)]
        public double? VideoStartTs { get; set; }


    }
}
