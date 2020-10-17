using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0x1f69b606)]
    public class TLToggleSignatures : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1f69b606;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public bool Enabled { get; set; }


    }
}
