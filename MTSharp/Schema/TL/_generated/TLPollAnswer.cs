using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6ca9c2e9)]
    public class TLPollAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6ca9c2e9;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Option { get; set; }


    }
}
