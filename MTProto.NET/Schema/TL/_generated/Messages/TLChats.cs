using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0x64ff9fd5)]
    public class TLChats : TLAbsChats
    {
        public override uint Constructor
        {
            get
            {
                return 0x64ff9fd5;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsChat> Chats { get; set; }


    }
}
