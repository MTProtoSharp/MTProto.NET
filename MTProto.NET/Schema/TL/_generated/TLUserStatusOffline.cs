using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8c703f)]
    public class TLUserStatusOffline : TLAbsUserStatus
    {
        public override uint Constructor
        {
            get
            {
                return 0x8c703f;
            }
        }

        [MTParameter(Order = 0)]
        public int WasOnline { get; set; }


    }
}
