using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbd610bc9)]
    public class TLMessageEntityBold : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0xbd610bc9;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
