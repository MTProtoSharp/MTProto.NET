using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xd5b10c26)]
    public class TLGetEmojiURL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd5b10c26;
            }
        }

        [MTParameter(Order = 0)]
        public string LangCode { get; set; }


    }
}
