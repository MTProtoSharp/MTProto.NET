using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x12b299d4)]
    public class TLStickerPack : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x12b299d4;
            }
        }

        [MTParameter(Order = 0)]
        public string Emoticon { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<long> Documents { get; set; }


    }
}
