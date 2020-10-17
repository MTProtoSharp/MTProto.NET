using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7e6260d7)]
    public class TLTextConcat : TLAbsRichText
    {
        public override uint Constructor
        {
            get
            {
                return 0x7e6260d7;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsRichText> Texts { get; set; }


    }
}
