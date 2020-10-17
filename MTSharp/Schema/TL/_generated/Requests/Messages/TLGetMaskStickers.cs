using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x65b8c79f)]
    public class TLGetMaskStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x65b8c79f;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
