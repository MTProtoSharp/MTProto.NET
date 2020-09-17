using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe0b0bc2e)]
    public class TLPhotoStrippedSize : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0b0bc2e;
            }
        }

        [MTParameter(Order = 0)]
        public string Type { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Bytes { get; set; }


    }
}
