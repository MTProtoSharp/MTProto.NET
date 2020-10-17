using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa575739d)]
    public class TLEmojiURL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa575739d;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }


    }
}
