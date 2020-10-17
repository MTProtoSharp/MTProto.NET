using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x35a0e062)]
    public class TLGetEmojiKeywords : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x35a0e062;
            }
        }

        [MTParameter(Order = 0)]
        public string LangCode { get; set; }


    }
}
