using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4a992157)]
    public class TLInputStickeredMediaPhoto : TLAbsInputStickeredMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x4a992157;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPhoto Id { get; set; }


    }
}
