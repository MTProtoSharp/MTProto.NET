using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xdbd4feed)]
    public class TLInputReportReasonGeoIrrelevant : TLAbsReportReason
    {
        public override uint Constructor
        {
            get
            {
                return 0xdbd4feed;
            }
        }



    }
}
