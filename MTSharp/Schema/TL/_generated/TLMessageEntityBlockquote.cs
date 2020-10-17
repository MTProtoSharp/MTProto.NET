using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x20df5d0)]
    public class TLMessageEntityBlockquote : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x20df5d0;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
