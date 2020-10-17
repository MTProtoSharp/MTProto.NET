using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x826f8b60)]
    public class TLMessageEntityItalic : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x826f8b60;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
