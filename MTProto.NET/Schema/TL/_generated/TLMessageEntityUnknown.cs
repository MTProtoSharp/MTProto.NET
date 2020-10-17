using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbb92ba95)]
    public class TLMessageEntityUnknown : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0xbb92ba95;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
