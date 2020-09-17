using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x162ecc1f)]
    public class TLFoundGif : TLAbsFoundGif
    {
        public override uint Constructor
        {
            get
            {
                return 0x162ecc1f;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public string ThumbUrl { get; set; }
        [MTParameter(Order = 2)]
        public string ContentUrl { get; set; }
        [MTParameter(Order = 3)]
        public string ContentType { get; set; }
        [MTParameter(Order = 4)]
        public int W { get; set; }
        [MTParameter(Order = 5)]
        public int H { get; set; }


    }
}
