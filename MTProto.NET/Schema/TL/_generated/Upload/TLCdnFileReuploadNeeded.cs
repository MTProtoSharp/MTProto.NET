using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Upload
{
    [MTObject(0xeea8e46e)]
    public class TLCdnFileReuploadNeeded : TLAbsCdnFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xeea8e46e;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] RequestToken { get; set; }


    }
}
