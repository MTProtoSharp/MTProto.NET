using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x438865b)]
    public class TLInputStickeredMediaDocument : TLAbsInputStickeredMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x438865b;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputDocument Id { get; set; }


    }
}
