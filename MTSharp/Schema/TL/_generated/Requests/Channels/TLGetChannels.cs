using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xa7f6bbb)]
    public class TLGetChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa7f6bbb;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputChannel> Id { get; set; }


    }
}
