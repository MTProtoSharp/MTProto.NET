using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa26f881b)]
    public class TLChannelAdminLogEventActionChangeLinkedChat : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xa26f881b;
            }
        }

        [MTParameter(Order = 0)]
        public int PrevValue { get; set; }
        [MTParameter(Order = 1)]
        public int NewValue { get; set; }


    }
}
