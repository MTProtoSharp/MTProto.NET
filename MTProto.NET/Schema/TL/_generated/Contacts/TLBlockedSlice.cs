using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Contacts
{
    [MTObject(0x900802a1)]
    public class TLBlockedSlice : TLAbsBlocked
    {
        public override uint Constructor
        {
            get
            {
                return 0x900802a1;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTProto.NET.Schema.TL.TLContactBlocked> Blocked { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
