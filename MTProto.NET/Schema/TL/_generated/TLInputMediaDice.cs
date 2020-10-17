using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe66fbf7b)]
    public class TLInputMediaDice : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xe66fbf7b;
            }
        }

        [MTParameter(Order = 0)]
        public string Emoticon { get; set; }


    }
}
