using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Phone
{
    [MTObject(0x277add7e)]
    public class TLSaveCallDebug : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x277add7e;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputPhoneCall Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLDataJSON Debug { get; set; }


    }
}
