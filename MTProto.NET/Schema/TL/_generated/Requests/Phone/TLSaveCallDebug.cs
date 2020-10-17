using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Phone
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
        public MTProto.NET.Schema.TL.TLInputPhoneCall Peer { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLDataJSON Debug { get; set; }


    }
}
