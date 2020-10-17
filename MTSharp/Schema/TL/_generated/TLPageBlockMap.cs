using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa44f3ef6)]
    public class TLPageBlockMap : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xa44f3ef6;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsGeoPoint Geo { get; set; }
        [MTParameter(Order = 1)]
        public int Zoom { get; set; }
        [MTParameter(Order = 2)]
        public int W { get; set; }
        [MTParameter(Order = 3)]
        public int H { get; set; }
        [MTParameter(Order = 4)]
        public MTSharp.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
