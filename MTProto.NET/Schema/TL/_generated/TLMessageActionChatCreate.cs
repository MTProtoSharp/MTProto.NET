using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa6638b9a)]
    public class TLMessageActionChatCreate : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xa6638b9a;
            }
        }

        [MTParameter(Order = 0)]
        public string Title { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Users { get; set; }


    }
}
