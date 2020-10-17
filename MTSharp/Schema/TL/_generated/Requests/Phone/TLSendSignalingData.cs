using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Phone
{
    [MTObject(0xff7a9383)]
    public class TLSendSignalingData : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xff7a9383;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputPhoneCall Peer { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Data { get; set; }


    }
}
