using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xa927fec5)]
    public class TLInactiveChats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa927fec5;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Dates { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
