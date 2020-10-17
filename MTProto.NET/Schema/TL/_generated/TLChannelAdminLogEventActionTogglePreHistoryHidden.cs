using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x5f5c95f1)]
    public class TLChannelAdminLogEventActionTogglePreHistoryHidden : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x5f5c95f1;
            }
        }

        [MTParameter(Order = 0)]
        public bool NewValue { get; set; }


    }
}
