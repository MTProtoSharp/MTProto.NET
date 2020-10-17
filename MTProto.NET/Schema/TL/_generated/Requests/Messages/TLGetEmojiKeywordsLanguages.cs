using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x4e9963b2)]
    public class TLGetEmojiKeywordsLanguages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4e9963b2;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<string> LangCodes { get; set; }


    }
}
