using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbf0693d4)]
    public class TLMessageEntityStrike : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf0693d4;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
