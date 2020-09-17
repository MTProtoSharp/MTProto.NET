using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd5b3b9f9)]
    public class TLEmojiKeyword : TLAbsEmojiKeyword
    {
        public override uint Constructor
        {
            get
            {
                return 0xd5b3b9f9;
            }
        }

        [MTParameter(Order = 0)]
        public string Keyword { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<string> Emoticons { get; set; }


    }
}
