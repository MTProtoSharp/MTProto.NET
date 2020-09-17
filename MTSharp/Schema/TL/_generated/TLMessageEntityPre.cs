using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x73924be0)]
    public class TLMessageEntityPre : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x73924be0;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }
        [MTParameter(Order = 2)]
        public string Language { get; set; }


    }
}
