using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3417d728)]
    public class TLInputPaymentCredentials : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0x3417d728;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Save { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLDataJSON Data { get; set; }


    }
}
