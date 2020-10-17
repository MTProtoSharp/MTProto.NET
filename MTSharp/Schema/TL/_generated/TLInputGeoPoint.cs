using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf3b7acc9)]
    public class TLInputGeoPoint : TLAbsInputGeoPoint
    {
        public override uint Constructor
        {
            get
            {
                return 0xf3b7acc9;
            }
        }

        [MTParameter(Order = 0)]
        public double Lat { get; set; }
        [MTParameter(Order = 1)]
        public double Long { get; set; }


    }
}
