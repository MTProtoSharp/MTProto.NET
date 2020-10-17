using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x43d4f2c)]
    public class TLGetStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x43d4f2c;
            }
        }

        [MTParameter(Order = 0)]
        public string Emoticon { get; set; }
        [MTParameter(Order = 1)]
        public int Hash { get; set; }


    }
}
