using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Contacts
{
    [MTObject(0x1c138d15)]
    public class TLBlocked : TLAbsBlocked
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c138d15;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLContactBlocked> Blocked { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
