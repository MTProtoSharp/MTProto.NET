using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x1c9618b1)]
    public class TLGetAllStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c9618b1;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
