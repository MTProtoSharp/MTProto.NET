using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb3fb5361)]
    public class TLEmojiLanguage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb3fb5361;
            }
        }

        [MTParameter(Order = 0)]
        public string LangCode { get; set; }


    }
}
