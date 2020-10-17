using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfa04579d)]
    public class TLMessageEntityMention : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0xfa04579d;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
