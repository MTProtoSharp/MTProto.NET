using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x7fcb13a8)]
    public class TLMessageActionChatEditPhoto : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x7fcb13a8;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPhoto Photo { get; set; }


    }
}
