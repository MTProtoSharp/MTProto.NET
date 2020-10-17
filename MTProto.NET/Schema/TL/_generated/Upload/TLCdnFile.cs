using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Upload
{
    [MTObject(0xa99fca4f)]
    public class TLCdnFile : TLAbsCdnFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xa99fca4f;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Bytes { get; set; }


    }
}
