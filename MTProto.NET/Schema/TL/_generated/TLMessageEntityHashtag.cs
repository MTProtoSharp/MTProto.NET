using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x6f635b0d)]
    public class TLMessageEntityHashtag : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x6f635b0d;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
