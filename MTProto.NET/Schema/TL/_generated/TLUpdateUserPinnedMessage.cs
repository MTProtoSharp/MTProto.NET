using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4c43da18)]
    public class TLUpdateUserPinnedMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x4c43da18;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }


    }
}
