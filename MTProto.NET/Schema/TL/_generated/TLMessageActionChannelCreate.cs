using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x95d2ac92)]
    public class TLMessageActionChannelCreate : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x95d2ac92;
            }
        }

        [MTParameter(Order = 0)]
        public string Title { get; set; }


    }
}
