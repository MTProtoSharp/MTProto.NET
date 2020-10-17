using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x21ce0b0e)]
    public class TLGetFavedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x21ce0b0e;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
