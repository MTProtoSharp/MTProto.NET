using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4e90bfd6)]
    public class TLUpdateMessageID : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x4e90bfd6;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }
        [MTParameter(Order = 1)]
        public long RandomId { get; set; }


    }
}
