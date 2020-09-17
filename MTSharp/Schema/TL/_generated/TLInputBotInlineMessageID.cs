using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x890c3d89)]
    public class TLInputBotInlineMessageID : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x890c3d89;
            }
        }

        [MTParameter(Order = 0)]
        public int DcId { get; set; }
        [MTParameter(Order = 1)]
        public long Id { get; set; }
        [MTParameter(Order = 2)]
        public long AccessHash { get; set; }


    }
}
