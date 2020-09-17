using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0xf49ca0)]
    public class TLDifference : TLAbsDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0xf49ca0;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsMessage> NewMessages { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsEncryptedMessage> NewEncryptedMessages { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUpdate> OtherUpdates { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsUser> Users { get; set; }
        [MTParameter(Order = 5)]
        public MTSharp.Schema.TL.Updates.TLState State { get; set; }


    }
}
