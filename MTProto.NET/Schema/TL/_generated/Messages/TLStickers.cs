using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xe4599bbd)]
    public class TLStickers : TLAbsStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xe4599bbd;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsDocument> Stickers { get; set; }


    }
}
