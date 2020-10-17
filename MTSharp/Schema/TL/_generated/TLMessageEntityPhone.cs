using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9b69e34b)]
    public class TLMessageEntityPhone : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x9b69e34b;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
