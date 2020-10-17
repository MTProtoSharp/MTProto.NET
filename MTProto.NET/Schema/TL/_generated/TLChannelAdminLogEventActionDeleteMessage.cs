using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x42e047bb)]
    public class TLChannelAdminLogEventActionDeleteMessage : TLAbsChannelAdminLogEventAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x42e047bb;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsMessage Message { get; set; }


    }
}
