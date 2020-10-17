using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x77bfb61b)]
    public class TLPhotoSize : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0x77bfb61b;
            }
        }

        [MTParameter(Order = 0)]
        public string Type { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated Location { get; set; }
        [MTParameter(Order = 2)]
        public int W { get; set; }
        [MTParameter(Order = 3)]
        public int H { get; set; }
        [MTParameter(Order = 4)]
        public int Size { get; set; }


    }
}
