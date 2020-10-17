using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7bf09fc)]
    public class TLUserStatusLastWeek : TLAbsUserStatus
    {
        public override uint Constructor
        {
            get
            {
                return 0x7bf09fc;
            }
        }



    }
}
