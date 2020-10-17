using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xe58e95d2)]
    public class TLDeleteMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe58e95d2;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Revoke { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<int> Id { get; set; }


    }
}
