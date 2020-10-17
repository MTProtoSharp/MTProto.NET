using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0x15ba6c40)]
    public class TLDialogs : TLAbsDialogs
    {
        public override uint Constructor
        {
            get
            {
                return 0x15ba6c40;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsDialog> Dialogs { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsMessage> Messages { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
