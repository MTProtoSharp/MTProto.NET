using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x450a1c0a)]
    public class TLFoundGifs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x450a1c0a;
            }
        }

        [MTParameter(Order = 0)]
        public int NextOffset { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsFoundGif> Results { get; set; }


    }
}
