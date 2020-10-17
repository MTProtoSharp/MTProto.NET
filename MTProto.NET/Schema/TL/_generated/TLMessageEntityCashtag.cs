using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4c4e743f)]
    public class TLMessageEntityCashtag : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x4c4e743f;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
