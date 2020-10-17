using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x98a12b4b)]
    public class TLUpdateChannelMessageViews : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x98a12b4b;
            }
        }

        [MTParameter(Order = 0)]
        public int ChannelId { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }
        [MTParameter(Order = 2)]
        public int Views { get; set; }


    }
}
