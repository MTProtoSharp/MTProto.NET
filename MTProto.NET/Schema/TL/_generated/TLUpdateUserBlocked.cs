using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x80ece81a)]
    public class TLUpdateUserBlocked : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x80ece81a;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public bool Blocked { get; set; }


    }
}
