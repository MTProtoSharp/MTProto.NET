using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6ed02538)]
    public class TLMessageEntityUrl : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x6ed02538;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
