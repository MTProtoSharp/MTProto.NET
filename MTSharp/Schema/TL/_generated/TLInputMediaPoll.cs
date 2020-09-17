using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6b3765b)]
    public class TLInputMediaPoll : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x6b3765b;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLPoll Poll { get; set; }


    }
}
