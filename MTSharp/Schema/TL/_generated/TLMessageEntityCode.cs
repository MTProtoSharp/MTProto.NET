using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x28a20571)]
    public class TLMessageEntityCode : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x28a20571;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
