using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x5dab1af4)]
    public class TLExportedMessageLink : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5dab1af4;
            }
        }

        [MTParameter(Order = 0)]
        public string Link { get; set; }
        [MTParameter(Order = 1)]
        public string Html { get; set; }


    }
}
