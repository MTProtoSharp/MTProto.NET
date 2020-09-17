using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb055eaee)]
    public class TLMessageActionChannelMigrateFrom : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xb055eaee;
            }
        }

        [MTParameter(Order = 0)]
        public string Title { get; set; }
        [MTParameter(Order = 1)]
        public int ChatId { get; set; }


    }
}
