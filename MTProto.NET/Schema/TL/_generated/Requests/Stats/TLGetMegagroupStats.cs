using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Stats
{
    [MTObject(0xdcdf8607)]
    public class TLGetMegagroupStats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdcdf8607;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Dark { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputChannel Channel { get; set; }


    }
}
