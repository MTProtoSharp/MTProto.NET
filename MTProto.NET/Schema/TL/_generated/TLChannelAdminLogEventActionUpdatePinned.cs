using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe9e82c18)]
    public class TLChannelAdminLogEventActionUpdatePinned : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xe9e82c18;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsMessage Message { get; set; }


    }
}
