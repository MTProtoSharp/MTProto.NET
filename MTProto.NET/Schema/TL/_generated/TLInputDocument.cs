using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1abfb575)]
    public class TLInputDocument : TLAbsInputDocument
    {
        public override uint Constructor
        {
            get
            {
                return 0x1abfb575;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 2)]
        public byte[] FileReference { get; set; }


    }
}
