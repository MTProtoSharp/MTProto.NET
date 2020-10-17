using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x1508b6af)]
    public class TLGetEmojiKeywordsDifference : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1508b6af;
            }
        }

        [MTParameter(Order = 0)]
        public string LangCode { get; set; }
        [MTParameter(Order = 1)]
        public int FromVersion { get; set; }


    }
}
