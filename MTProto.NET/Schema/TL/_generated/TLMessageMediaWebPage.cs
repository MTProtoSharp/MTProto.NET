using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa32dd600)]
    public class TLMessageMediaWebPage : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xa32dd600;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsWebPage Webpage { get; set; }


    }
}
