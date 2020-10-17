using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x9d05049)]
    public class TLUserStatusEmpty : TLAbsUserStatus
    {
        public override uint Constructor
        {
            get
            {
                return 0x9d05049;
            }
        }



    }
}
