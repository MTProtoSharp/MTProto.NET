using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x6cef8ac7)]
    public class TLMessageEntityBotCommand : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x6cef8ac7;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
