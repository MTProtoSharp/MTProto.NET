using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfdb19008)]
    public class TLMessageMediaGame : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xfdb19008;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLGame Game { get; set; }


    }
}
