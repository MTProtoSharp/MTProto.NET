using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x236df622)]
    public class TLEmojiKeywordDeleted : TLAbsEmojiKeyword
    {
        public override uint Constructor
        {
            get
            {
                return 0x236df622;
            }
        }

        [MTParameter(Order = 0)]
        public string Keyword { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<string> Emoticons { get; set; }


    }
}
