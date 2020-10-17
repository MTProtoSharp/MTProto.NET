using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xcc5b67cc)]
    public class TLGetAttachedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcc5b67cc;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputStickeredMedia Media { get; set; }


    }
}
