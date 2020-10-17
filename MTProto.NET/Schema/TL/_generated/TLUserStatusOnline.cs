using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xedb93949)]
    public class TLUserStatusOnline : TLAbsUserStatus
    {
        public override uint Constructor
        {
            get
            {
                return 0xedb93949;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }


    }
}
