using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x2331b22d)]
    public class TLPhotoEmpty : TLAbsPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x2331b22d;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }


    }
}
