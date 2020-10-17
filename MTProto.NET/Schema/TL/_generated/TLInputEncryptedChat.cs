using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf141b5e1)]
    public class TLInputEncryptedChat : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf141b5e1;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
