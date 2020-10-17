using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x58dbcab8)]
    public class TLInputReportReasonSpam : TLAbsReportReason
    {
        public override uint Constructor
        {
            get
            {
                return 0x58dbcab8;
            }
        }



    }
}
