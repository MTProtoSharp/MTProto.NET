using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Phone
{
    [MTObject(0x17d54f61)]
    public class TLReceivedCall : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x17d54f61;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputPhoneCall Peer { get; set; }


    }
}
