using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xb9ffc55b)]
    public class TLFaveSticker : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb9ffc55b;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputDocument Id { get; set; }
        [MTParameter(Order = 1)]
        public bool Unfave { get; set; }


    }
}
