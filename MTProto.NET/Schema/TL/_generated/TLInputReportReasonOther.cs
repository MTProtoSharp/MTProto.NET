using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe1746d0a)]
    public class TLInputReportReasonOther : TLAbsReportReason
    {
        public override uint Constructor
        {
            get
            {
                return 0xe1746d0a;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
