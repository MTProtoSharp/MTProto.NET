using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3f7ee58b)]
    public class TLMessageMediaDice : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x3f7ee58b;
            }
        }

        [MTParameter(Order = 0)]
        public int Value { get; set; }
        [MTParameter(Order = 1)]
        public string Emoticon { get; set; }


    }
}
