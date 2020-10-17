using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x9c4e7e8b)]
    public class TLMessageEntityUnderline : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c4e7e8b;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
