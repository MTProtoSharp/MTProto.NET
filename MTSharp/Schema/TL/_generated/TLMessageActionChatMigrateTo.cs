using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x51bdb021)]
    public class TLMessageActionChatMigrateTo : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x51bdb021;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }


    }
}
