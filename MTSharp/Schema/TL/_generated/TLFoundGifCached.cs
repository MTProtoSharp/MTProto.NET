using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9c750409)]
    public class TLFoundGifCached : TLAbsFoundGif
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c750409;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsDocument Document { get; set; }


    }
}
